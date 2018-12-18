void setup()   
{  
    Serial.begin(9600);
    pinMode(13, OUTPUT); 
    pinMode(12,OUTPUT);
    pinMode(11,OUTPUT);
    pinMode(10,OUTPUT); 
    pinMode(9 ,OUTPUT);
    pinMode(8,OUTPUT);
    pinMode(7,OUTPUT); 
    pinMode(6 ,OUTPUT);
    pinMode(5,OUTPUT);
     
}  
  
void loop()   
{  
    if (Serial.available() > 0)   
    {  
        char c = Serial.read();  
        if (c == '1')   
        {  
            
            digitalWrite(13, HIGH);
            digitalWrite(12, LOW);
            digitalWrite(11, LOW);
            digitalWrite(10, LOW);
            digitalWrite(9,  LOW);
            digitalWrite(8,  LOW);
            digitalWrite(7,  LOW);
            digitalWrite(6,  LOW);
            digitalWrite(5,  LOW);
            
        } else if (c == '2')   
        {  
            digitalWrite(13, LOW);
            digitalWrite(12, HIGH);
            digitalWrite(11, LOW);
            digitalWrite(10, LOW);
            digitalWrite(9,  LOW); 
            digitalWrite(8, LOW);
            digitalWrite(7,  LOW);
            digitalWrite(6,  LOW);
            digitalWrite(5,  LOW);
              
        }else if (c == '3')   
        {  
            digitalWrite(13, LOW);
            digitalWrite(12, LOW);
            digitalWrite(11, HIGH);
            digitalWrite(10, LOW);
            digitalWrite(9,  LOW);
            digitalWrite(8,  LOW);
            digitalWrite(7,  LOW);
            digitalWrite(6,  LOW);
            digitalWrite(5,  LOW); 
        }else if (c == '4')   
        {  
            digitalWrite(13, LOW);
            digitalWrite(12, LOW);
            digitalWrite(11, LOW);
            digitalWrite(10, HIGH);
            digitalWrite(9, LOW); 
            digitalWrite(8, LOW); 
            digitalWrite(7,  LOW);
            digitalWrite(6,  LOW);
            digitalWrite(5,  LOW);
        }else if (c == '5')   
        {  
            digitalWrite(13, LOW);
            digitalWrite(12, LOW);
            digitalWrite(11, LOW);
            digitalWrite(10, LOW);
            digitalWrite(9, HIGH);
            digitalWrite(8, LOW);   
            digitalWrite(7,  LOW);
            digitalWrite(6,  LOW);
            digitalWrite(5,  LOW);    
          }else if (c == '6')   
        {  
            digitalWrite(13, LOW);
            digitalWrite(12, LOW);
            digitalWrite(11, LOW);
            digitalWrite(10, LOW);
            digitalWrite(9, LOW); 
            digitalWrite(8, HIGH);
            digitalWrite(7,  LOW);
            digitalWrite(6,  LOW);
            digitalWrite(5,  LOW);  
          
    }else if (c == '7')   
        {  
            digitalWrite(13, LOW);
            digitalWrite(12, LOW);
            digitalWrite(11, LOW);
            digitalWrite(10, LOW);
            digitalWrite(9, LOW); 
            digitalWrite(8, LOW);
            digitalWrite(7,  HIGH);
            digitalWrite(6,  LOW);
            digitalWrite(5,  LOW);  
           
    }else if (c == '8')   
        {  
            digitalWrite(13, LOW);
            digitalWrite(12, LOW);
            digitalWrite(11, LOW);
            digitalWrite(10, LOW);
            digitalWrite(9, LOW); 
            digitalWrite(8, LOW);
            digitalWrite(7,  LOW);
            digitalWrite(6,  HIGH);
            digitalWrite(5,  LOW);  
      
                    
    }else if (c == '9')   
        {  
            digitalWrite(13, LOW);
            digitalWrite(12, LOW);
            digitalWrite(11, LOW);
            digitalWrite(10, LOW);
            digitalWrite(9, LOW); 
            digitalWrite(8, LOW);
            digitalWrite(7,  LOW);
            digitalWrite(6,  LOW);
            digitalWrite(5,  HIGH);  
        } 
}
}
