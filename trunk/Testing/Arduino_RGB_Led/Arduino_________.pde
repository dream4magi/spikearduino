/*
  Blink
 
 Turns on an LED on for one second, then off for one second, repeatedly.
 
 The circuit:
 * LED connected from digital pin 13 to ground.
 
 * Note: On most Arduino boards, there is already an LED on the board
 connected to pin 13, so you don't need any extra components for this example.
 
 
 Created 1 June 2005
 By David Cuartielles
 
 http://arduino.cc/en/Tutorial/Blink
 
 based on an orginal by H. Barragan for the Wiring i/o board
 
 */

int ledPin =  13;    // LED connected to digital pin 13
int sensorPin = 8;
int GND = 10;
int VCC = 9;

int GND2 = 4;
int colorRed = 3;
int colorGreen = 5;
int colorBlue = 6;
// The setup() method runs once, when the sketch starts
  int colorRed_i = 159;
  int colorGreen_i = 1;
  int colorBlue_i = 1;
void setup()   {         
Serial.begin(115200);  

  // initialize the digital pin as an output:
  pinMode(ledPin, OUTPUT); 
  pinMode(GND, OUTPUT); 
  pinMode(VCC, OUTPUT);  
  pinMode(sensorPin, INPUT);    
  digitalWrite(GND,LOW);
  digitalWrite(VCC,HIGH);
  
  pinMode(GND2, OUTPUT); 
  pinMode(colorGreen, OUTPUT);  
  pinMode(colorBlue, OUTPUT); 
  digitalWrite(GND2,LOW); 
  analogWrite(colorRed,colorRed_i);
 // digitalWrite(color1,LOW);
 // digitalWrite(color2,LOW);
}

// the loop() method runs over and over again,
// as long as the Arduino has power

void loop()                     
{
  digitalWrite(ledPin , digitalRead(sensorPin));
  delay(1);                  // wait for a second
  Serial.println("Start");
  
  

  
  for(int i = 0;i<161;i++){
    colorGreen_i = i;
    analogWrite(colorGreen,colorGreen_i);
    delay(40);
  }
  printInfo();
  delay(200); 

   
  for(int i = 0;i<161;i++){
    colorRed_i = 160 - i;
    analogWrite(colorRed,colorRed_i);
    delay(40);
  }
  printInfo();
  delay(200);
  
  for(int i = 0;i<161;i++){
    colorBlue_i = i;
    analogWrite(colorBlue,colorBlue_i);
    delay(40);
  }
  printInfo();
  delay(200);
  
  for(int i = 0;i<161;i++){
    colorGreen_i =160 - i;
    analogWrite(colorGreen,colorGreen_i);
    delay(40);
  }
  printInfo();
  delay(200);
  
  
  
  
  for(int i = 0;i<161;i++){
    colorRed_i = i;
    analogWrite(colorRed,colorRed_i);
    delay(40);
  }
  printInfo();
  delay(200);
  
  for(int i = 0;i<161;i++){
    colorBlue_i = 160 - i;
    analogWrite(colorBlue,colorBlue_i);
    delay(40);
  }
  
  printInfo();
  delay(200);
}


void printInfo(){
  Serial.print("R:");
  Serial.print(colorRed_i);
  Serial.print(" G:");
  Serial.print(colorGreen_i);    
  Serial.print(" B:");
  Serial.println(colorBlue_i);
}
