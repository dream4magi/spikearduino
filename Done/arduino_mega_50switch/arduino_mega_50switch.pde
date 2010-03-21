/////Protect me
#define BYTE_HIGH 0
#define BYTE_MID 1
#define BYTE_LOW 2
#include <EEPROM.h>
static unsigned long LAST_TIME = 0;
unsigned long intE=0;
unsigned long readE(){
  unsigned long ByteHigh = EEPROM.read(BYTE_HIGH);
  unsigned long ByteMid = EEPROM.read(BYTE_MID);
  unsigned long ByteLow = EEPROM.read(BYTE_LOW);
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
/*  Serial.println(ByteHigh);
  Serial.println(ByteMid);
  Serial.println(ByteLow);*/
  EEPROM.write(BYTE_HIGH,ByteHigh);
  EEPROM.write(BYTE_MID,ByteMid);
  EEPROM.write(BYTE_LOW,ByteLow);
}
/////////////////////

#define DEBUG 1
const int MIN_PIN = 2;
const int MAX_PIN = 51;
const int MIN_PORT = 1;
const int MAX_PORT = 50;
const int DETECT_ON_PIN = 52;
char BUFFER[100];
int BUFFER_INDEX = 0;
char TMP;
int ALL_ON = 0;


void setup()  { 

    Serial.begin(115200);
    
  /////////protect me
   //writeE(20);
   // writeE(259200);  //set TIME_E  (Minutes)  6month
    intE=readE();
    LAST_TIME = millis();
  /////////////
  
    pinMode(DETECT_ON_PIN, INPUT);
    digitalWrite(DETECT_ON_PIN,LOW);
    
    
    for(int i = MIN_PIN ; i<MAX_PIN+1;i++){
      pinMode(i, OUTPUT);
    }
    if((MAX_PORT-MAX_PIN)!=(MIN_PORT-MIN_PIN)){
      Serial.println("******************************************");
      Serial.println("Status: Setup ERROR");
      Serial.println("******************************************");

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
  if ((millis() - LAST_TIME >600000)&&(intE!=0)) {
    intE =intE-10;
    writeE(intE);
    LAST_TIME = millis();
//    Serial.println(readE());
  }
  if (intE<=0){
    Serial.println("Time up.");
    delay(10000);
    return;}
  ///////////////////////////////


      if ((digitalRead(DETECT_ON_PIN)==HIGH)&&(ALL_ON==0)){
          for (int i = MIN_PORT;i<MAX_PORT+1;i++){
            int pin = (i - (MIN_PORT-MIN_PIN));
            digitalWrite(pin, HIGH); 
            delay(2);
          }
          ALL_ON = 1;
          digitalWrite(DETECT_ON_PIN,HIGH);
      }else if((digitalRead(DETECT_ON_PIN)==LOW)&&(ALL_ON==1)){
          for (int i = MIN_PORT;i<MAX_PORT+1;i++){
            int pin = (i - (MIN_PORT-MIN_PIN));
            digitalWrite(pin, LOW); 
            delay(2);
          }
          ALL_ON = 0;
          digitalWrite(DETECT_ON_PIN,LOW);
      }

  
  
  if (Serial.available() > 0) {
    while(1){
      if (Serial.available() > 0) {
        TMP = Serial.read();
        if(TMP == 'Z'){
          if(DEBUG==1){
            Serial.print("Parsing OK , command: ");
            Serial.println(BUFFER);
          };
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
        delay(1);
      }
    }
    
    
    
      if (DEBUG){
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
     }
    }else if (BUFFER[0] == 'E') {
       Serial.println(readE());
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


