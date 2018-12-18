using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Math.Geometry;
using System.IO.Ports;
using Point = System.Drawing.Point;
using System.Data;
using System.Linq;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection VideoCapTureDevices;
        private VideoCaptureDevice Sonvideo;
        SerialPort ardino = new SerialPort();           

        public Form1()
        {
            InitializeComponent();
        }

        int R; 
        int G;
        int B;
               
        private void Form1_Load(object sender, EventArgs e)
        {           
            
            VideoCapTureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCapTureDevices)
            {

                comboBox1.Items.Add(VideoCaptureDevice.Name);

            }

            comboBox1.SelectedIndex = 0;

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Sonvideo = new VideoCaptureDevice(VideoCapTureDevices[comboBox1.SelectedIndex].MonikerString);
            Sonvideo.NewFrame += new NewFrameEventHandler(Finalvideo_NewFrame);
            Sonvideo.DesiredFrameRate = 20;//FPS için
            Sonvideo.DesiredFrameSize = new Size(320, 240);//görüntü boyutları
            Sonvideo.Start();
        }

        void Finalvideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap goruntu = (Bitmap)eventArgs.Frame.Clone();
            Bitmap image1 = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = goruntu;

            

            if (rdiobtnKirmizi.Checked)
            {               
                // Filtre Oluşturma
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // Orta kolonu ve Yarıçapı ayarlama
                filter.CenterColor = new RGB(Color.FromArgb(215, 0, 0));
                filter.Radius = 100;
                // Filtre Uygulama
                filter.ApplyInPlace(image1);
                
                objebulma(image1);                
            }

            if (rdiobtnMavi.Checked)
            {
                // Filtre Oluşturma
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // Orta kolonu ve Yarıçapı ayarlama
                filter.CenterColor = new RGB(Color.FromArgb(30, 144, 255));
                filter.Radius = 100;
                // Filtre Uygulama
                filter.ApplyInPlace(image1);                
                objebulma(image1);
                
            }
            if(rdiobtnYesil.Checked){
                // Filtre Oluşturma
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // Orta kolonu ve Yarıçapı ayarlama
                filter.CenterColor = new RGB(Color.FromArgb(0, 215, 0));
                filter.Radius = 100;
                // Filtre uygulama
                filter.ApplyInPlace(image1);

                objebulma(image1);
                                  
            }
            

            if (rdbtnElleBelirleme.Checked)
            {
                                            
                 // Filtre Oluşturma
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // Orta kolonu ve Yarıçapı ayarlama
                filter.CenterColor = new RGB(Color.FromArgb(R, G, B));
                filter.Radius = 100;
                // Filtre Uygulama
                filter.ApplyInPlace(image1);

                objebulma(image1);

            }

          
          
        }
        public void objebulma(Bitmap goruntu)
        {
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 5;
            blobCounter.MinHeight = 5;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;            
            BitmapData objectsData = goruntu.LockBits(new Rectangle(0, 0, goruntu.Width, goruntu.Height), ImageLockMode.ReadOnly, goruntu.PixelFormat);           
            Grayscale grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            UnmanagedImage grayImage = grayscaleFilter.Apply(new UnmanagedImage(objectsData));           
            goruntu.UnlockBits(objectsData);


            blobCounter.ProcessImage(goruntu);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            Blob[] blobs = blobCounter.GetObjectsInformation();
            pictureBox2.Image = goruntu;

            if (rdiobtnTekCisimTakibi.Checked)
            {
                //Tekli cisim Takibi 
                foreach (Rectangle recs in rects)
                {
                    if (rects.Length > 0)
                    {
                        Rectangle nesndikd = rects[0];
                        
                        Graphics g = pictureBox1.CreateGraphics();
                        using (Pen pen = new Pen(Color.FromArgb(252, 3, 26), 2))
                        {
                            g.DrawRectangle(pen, nesndikd);
                        }
                        //Cizdirilen Dikdörtgenin Koordinatlari aliniyor.
                        int nesnex = nesndikd.X + (nesndikd.Width / 2);
                        int nesney = nesndikd.Y + (nesndikd.Height / 2);                                              
                        g.Dispose();
                       
                        if (nesnex > 100 && nesnex <= 200)
                        {
                            ardino.Write("c");
                        }
                        else if (nesnex <= 100 )
                        {
                            ardino.Write("l");
                        }
                        else if (nesnex > 200 )                        
                        {
                            ardino.Write("r");
                        }                         
                        if (nesney < 150)
                        {

                            ardino.Write("e");
                        }
                        else if (nesney > 300)
                        {
                            ardino.Write("f");
                        }
                                                                                             
                        if(chkKoordinatiGoster.Checked){
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.Text = nesndikd.Location.ToString() + "\n" + richTextBox1.Text + "\n"; ;
                        });
                        }
                    }
                }
            }                                   
        }       
        private Point[] ToPointsArray(List<IntPoint> points)
        {
            Point[] array = new Point[points.Count];

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new Point(points[i].X, points[i].Y);
            }

            return array;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Sonvideo.IsRunning)
            {
                Sonvideo.Stop();
                
            }
        }

        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B = trackBar3.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Sonvideo.IsRunning)
            {
                Sonvideo.Stop();

            }

            Application.Exit();
        }

        private void baglan_Click(object sender, EventArgs e)
        {
            try    
            {
                String portName = comboBox2.Text;   
                ardino.PortName = portName;    
                ardino.BaudRate = 9600;    
                ardino.Open();
                toolS.Text = "BAĞLANDI";    
            }    
            catch (Exception)    
            {

               toolS.Text = " PORTA BAĞLANMADI (UYGUN PORT SEÇİNİZ)"; 
            }    
        }

        private void bagkes_Click(object sender, EventArgs e)
        {
            try    
            {    
                ardino.Close();
                toolS.Text = "BAĞLANTI KESİLDİ ";    
            }    
            catch (Exception)    
            {    
    
               toolS.Text = "BAĞLAN VE SONRA BAĞLANTIYI KES";    
            }    
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}


