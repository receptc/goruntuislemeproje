#include <Servo.h>

int p_fltXYRadius[0];

Servo servo;

int servoPosition = 90;


int gelenveri = 0;   

void setup()
{
  Serial.begin(9600); 

  servo.attach(7); 
 
  servo.write(servoPosition); 


}

void loop()
{
  if (Serial.available() > 0) {
    // gelen veriyi oku
    gelenveri = Serial.read();

    switch(gelenveri)
    {
      //Sola Dönme
    case 'l':
      servoPosition+=1;
      delay(30);
      if (servoPosition > 180)
      {
        servoPosition = 180;
      }

      break;

      // Sağa Dönme
    case 'r': 
      servoPosition-=1;
      delay(30);
      if (servoPosition < 0)
      {
        servoPosition = 0;
      }

      break;

 
    }
    servo.write(servoPosition);


  }
}
