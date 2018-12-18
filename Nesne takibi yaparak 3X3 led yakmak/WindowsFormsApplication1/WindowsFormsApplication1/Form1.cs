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
            Sonvideo.DesiredFrameRate = 20;//saniyede kaç görüntü alsın istiyorsanız. FPS
            Sonvideo.DesiredFrameSize = new Size(360, 240);//görüntü boyutları
            Sonvideo.Start();
        }

        void Finalvideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap goruntu = (Bitmap)eventArgs.Frame.Clone();
            Bitmap goruntu1 = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = goruntu;

            

            if (rdiobtnKirmizi.Checked)
            {
                
                // Filtre Oluşturma
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // orta kolonu ve yarıçapı ayarlama
                filter.CenterColor = new RGB(Color.FromArgb(215, 0, 0));
                filter.Radius = 100;
                // Filtre Uygulama
                filter.ApplyInPlace(goruntu1);

                
                nesnebul(goruntu1);
                
            }

            if (rdiobtnMavi.Checked)
            {

                // Filtre Oluşturma
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // orta kolonu ve yarıçapı ayarlama
                filter.CenterColor = new RGB(Color.FromArgb(30, 144, 255));
                filter.Radius = 100;
                // Filtre Uygulama
                filter.ApplyInPlace(goruntu1);
                
                nesnebul(goruntu1);
                
            }
            if(rdiobtnYesil.Checked){

                // Filtre Oluşturma
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // orta kolonu ve yarıçapı ayarlama
                filter.CenterColor = new RGB(Color.FromArgb(0, 215, 0));
                filter.Radius = 100;
                // Filtre Uygulama
                filter.ApplyInPlace(goruntu1);

                nesnebul(goruntu1);
            
            
            
            }
            

            if (rdbtnElleBelirleme.Checked)
            {

                // Filtre Oluşturma
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // orta kolonu ve yarıçapı ayarlama
                filter.CenterColor = new RGB(Color.FromArgb(R, G, B));
                filter.Radius = 100;
                // Filtre Uygulama
                filter.ApplyInPlace(goruntu1);

                nesnebul(goruntu1);

            }

          
          
        }
        public void nesnebul(Bitmap goruntu)
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
                //Tekli cisim Takibi Single Tracking--------

                foreach (Rectangle recs in rects)
                {
                    if (rects.Length > 0)
                    {
                        Rectangle nesnedikd = rects[0];
                        //Graphics g = Graphics.FromImage(goruntu);
                        Graphics g = pictureBox1.CreateGraphics();
                        using (Pen pen = new Pen(Color.FromArgb(252, 3, 26), 2))
                        {
                            g.DrawRectangle(pen, nesnedikd);
                        }
                        //Cizdirilen Dikdörtgenin Koordinatlari aliniyor.
                        int nesnex = nesnedikd.X + (nesnedikd.Width / 2);
                        int nesney = nesnedikd.Y + (nesnedikd.Height / 2);
                        //  g.DrawString(nesnex.ToString() + "X" + objectY.ToString(), new Font("Arial", 12), Brushes.Red, new System.Drawing.Point(250, 1));
                       
                        g.Dispose();
                       
                        if (nesnex <= 120 && nesney <= 80)
                        {
                            ardino.Write("1");
                        }
                        else if (nesnex>120 && nesnex<240 &&nesney <=80)
                        {
                            ardino.Write("2");
                        }
                      else if (nesnex > 240 && nesnex < 360 && nesney <= 80)
                        {
                            ardino.Write("3");
                        }
                        else if (nesnex <= 120 && nesney > 80 && nesney < 160)
                        {
                            ardino.Write("4");
                        }
                        else if (nesnex > 120 && nesnex < 240 && nesney > 80 && nesney < 160)

                        {
                            ardino.Write("5");
                        }

                        else if (nesnex > 240 && nesnex < 360 && nesney > 80 && nesney < 160)
                        {
                            ardino.Write("6");
                        }

                        else if (nesnex <= 120 && nesney > 160 && nesney < 240)
                        {
                            ardino.Write("7");
                        }
                        else if (nesnex > 120 && nesnex < 240 && nesney > 160 && nesney < 240)

                        {
                            ardino.Write("8");
                        }
                        else if (nesnex > 240 && nesnex < 360 && nesney > 160 && nesney < 240)
                        {
                            ardino.Write("9");
                        }



                                             
                        
                    }
                }
            }

    

            

    

            
        }

        // AForge.NET noktalarının listesini .NET noktalarının dizisine dönüştürme
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
               tool.Text = "BAĞLANDI";    
            }    
            catch (Exception)    
            {

                tool.Text = " PORTA BAĞLANDI (UYGUN PORTU SEÇİNİZ)"; 
            }    
        }

        private void bagkes_Click(object sender, EventArgs e)
        {
            try    
            {    
                ardino.Close();
                tool.Text = "BAĞLANTI KESİLDİ ";    
            }    
            catch (Exception)    
            {    
    
                tool.Text = "BAĞLAN SONRA BAĞLANTIYI KES";    
            }    
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }


}


