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




void setup()
{
    /////////protect me
    writeE(259200);  //set TIME_E  (Minutes)  6month
    intE=readE();
    LAST_TIME = millis();
  /////////////
  Serial.begin(115200);

Serial.println(readE());
}

void loop()
{
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

delay(5000);
Serial.println("OK");
}

