/////Protect me
#define BYTE_HIGH 0
#define BYTE_MID 1
#define BYTE_LOW 2
#include <EEPROM.h>
static unsigned long LAST_TIME = 0;
static unsigned long intE=0;
unsigned long readE(){
  int ByteHigh = EEPROM.read(0);
  int ByteMid = EEPROM.read(1);
  int ByteLow = EEPROM.read(2);
  return  ByteHigh*65536 + ByteMid*256 + ByteLow;
}
void writeE(unsigned long value){
  if (value < 0){
    value = 0;
  }else if(value>16777215){
    value = 16777215;
  }
  int ByteHigh = int(value / 65536);
  int ByteMid = int((value -ByteHigh*65536)/256);
  int ByteLow = value % 256;
  EEPROM.write(0,ByteHigh);
  EEPROM.write(1,ByteMid);
  EEPROM.write(2,ByteLow);
}
/////////////////////



const int MIN_PIN = 2;
const int MAX_PIN = 7;
const int MIN_PORT = 1;
const int MAX_PORT = 6;
char BUFFER[100];
int BUFFER_INDEX = 0;
char TMP;


void setup()  { 
  /////////protect me
    writeE(259200);  //set TIME_E  (Minutes)  6month
    intE=readE();
    LAST_TIME = millis();
  /////////////
    Serial.begin(115200);
    
    for(int i = MIN_PIN ; i<MAX_PIN+1;i++){
      pinMode(i, OUTPUT);
    }
    if((MAX_PORT-MAX_PIN)!=(MIN_PORT-MIN_PIN)){
      Serial.println("*******Setup Error!*******");
    }else{
      Serial.println("******************************************");
      Serial.println("Status: Setup OK");
      Serial.println("  Use A[PORT_NO][ON/OFF]Z to send a command.");
        Serial.print("    PORT RANGE ");      Serial.print(MIN_PORT);      Serial.print(" ~ ");      Serial.println(MAX_PORT);
      Serial.println("    ON=1 , OFF=0");
      Serial.println("******************************************");
            
    }
    
} 
void loop()  {
 /////////Protect me
  if (millis() - LAST_TIME >60000) {
    intE--;
    writeE(intE);
    LAST_TIME = millis();
    Serial.println(readE());
  }
  if (intE<=0){
    Serial.println("Time up.");
    delay(5000);
    return;}
  ///////////////////////////////


  if (Serial.available() > 0) {
    while(1){
      if (Serial.available() > 0) {
        TMP = Serial.read();
        if(TMP == 'Z'){
          Serial.print("Parsing OK , command: ");
          Serial.println(BUFFER);
          DoCommand();
          clearBUFFER();
        }else{
          AddToBUFFER(TMP);
        }
      }else{
        break;
      }
    }
    
  
  }
  
}

void clearBUFFER(){
BUFFER_INDEX = 0 ;
}
void AddToBUFFER(char C){
  BUFFER[BUFFER_INDEX] = C;
  BUFFER[BUFFER_INDEX+1] = '\0';
  BUFFER_INDEX ++ ;
}
void DoCommand(){
  
  if (BUFFER[0] == 'A') {
    int num = atoi(&BUFFER[1]);
    int port = int(num / 10);
    int ifON = int(num % 10);
    
    if (   (!(   (port>MIN_PORT-1)&&(port<MAX_PORT+1)   ))  && 
           (port!=0)
       ){
          Serial.print("*** Error Port: ");
          Serial.println(port);
          return;    
    }
    if (!((ifON==1)||(ifON==0))){
          Serial.print("*** Error On/Off: ");
          Serial.println(ifON);
          return;    
    }
    
    
    if ((port>MIN_PORT-1) && (port<MAX_PORT+1)){
      int pin = (port - (MIN_PORT-MIN_PIN));
      digitalWrite(pin, ifON); 
    
    }else if(port == 0){
      for (int i = MIN_PORT;i<MAX_PORT+1;i++){
        int pin = (i - (MIN_PORT-MIN_PIN));
        digitalWrite(pin, ifON); 
      }
    }
    
    
    

    if (port == 0){
      Serial.print("All Pins");
    }else{
      Serial.print("Port ");
      Serial.print(port);
    }
    
    Serial.print(": ");
    if (ifON) {
      Serial.println("ON");
    }else{
      Serial.println("OFF");
    }
    

  }else{
     Serial.print("*** Error Start Character: ");
     Serial.println(BUFFER[0]);
  }
  /*else if (BUFFER[0] == 'B') {
    int angle = constrain(atoi(&BUFFER[1]), 0, 180);
    Serial.print("servoB goto angle:");
    Serial.println(angle);
    servoB.write(angle);
  }else if (BUFFER[0] == 'C') {
    int angle = constrain(atoi(&BUFFER[1]), 0, 180);
    Serial.print("servoC goto angle:");
    Serial.println(angle);
    servoC.write(angle);
  }else if (BUFFER[0] == 'D') {
    int angle = constrain(atoi(&BUFFER[1]), 0, 180);
    Serial.print("servoD goto angle:");
    Serial.println(angle);
    servoD.write(angle);
  }else if (BUFFER[0] == 'E') {
    int angle = constrain(atoi(&BUFFER[1]), 0, 180);
    Serial.print("servoE goto angle:");
    Serial.println(angle);
    servoE.write(angle);
  }else if (BUFFER[0] == 'F') {
    int angle = constrain(atoi(&BUFFER[1]), 0, 180);
    Serial.print("servoF goto angle:");
    Serial.println(angle);
    servoF.write(angle);
  } 
*/
}


