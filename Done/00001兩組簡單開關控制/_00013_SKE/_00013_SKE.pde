int SW1 = 2;
int SW2 = 3;
int SW3 = 4;
int SW4 = 5;
int SW5 = 6;

int inByte = 0;         // incoming serial byte
void setup()   {                
  // initialize the digital pin as an output:
  pinMode(SW1, OUTPUT);     
  pinMode(SW2, OUTPUT); 
    // initialize the digital pin as an output:
  pinMode(SW3, OUTPUT);     
  pinMode(SW4, OUTPUT); 
    // initialize the digital pin as an output:
  pinMode(SW5, OUTPUT);     

  Serial.begin(9600);  
}

void loop()                     
{
  if (Serial.available() > 0) {
    inByte = Serial.read();
    
    
    if (inByte == 49){  //1
       digitalWrite(SW1, HIGH);   // set the LED on    
       Serial.print("SW1 ON");
    }
    if (inByte == 50){  //2
       digitalWrite(SW1, LOW);   // set the LED on    
       Serial.print("SW1 OFF");
    }
    if (inByte == 51){  //3
       digitalWrite(SW2, HIGH);   // set the LED on    
       Serial.print("SW2 ON");
    }
    if (inByte == 52){  //4
       digitalWrite(SW2, LOW);   // set the LED on    
       Serial.print("SW2 OFF");
    }
    
    
    if (inByte == 53){  //5
       digitalWrite(SW3, HIGH);   // set the LED on    
       Serial.print("SW3 ON");
    }
    if (inByte == 54){  //6
       digitalWrite(SW3, LOW);   // set the LED on    
       Serial.print("SW3 OFF");
    }
    if (inByte == 55){  //7
       digitalWrite(SW4, HIGH);   // set the LED on    
       Serial.print("SW4 ON");
    }
    if (inByte == 56){  //8
       digitalWrite(SW4, LOW);   // set the LED on    
       Serial.print("SW4 OFF");
    }
    
    
    if (inByte == 57){  //9
       digitalWrite(SW5, HIGH);   // set the LED on    
       Serial.print("SW5 ON");
    }
    if (inByte == 48){  //0
       digitalWrite(SW5, LOW);   // set the LED on    
       Serial.print("SW5 OFF");
    }



  
  }
  
  /*
 
  delay(1000);                  // wait for a second
  digitalWrite(ledPin, LOW);    // set the LED off
  delay(1000);                  // wait for a second
  */
}
