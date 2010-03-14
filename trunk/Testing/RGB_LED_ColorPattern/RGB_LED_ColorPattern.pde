
#define COLOR_STEP 8
int CP_B[] = {0,5,16,26,45,76,100,140};
int CP_R[] = {0,3,10,20,36,55,65,70};
int CP_G[] = {0,7,20,40,66,110,135,165};

class clsPixel{
public:
clsPixel();
void clsPixel::setPin(int pin_B , int pin_R , int pin_G);

};

clsPixel::clsPixel(){
  

};
void clsPixel::setPin(int pin_B , int pin_R , int pin_G){


};
void setup(){
pinMode(12,OUTPUT);
pinMode(9,OUTPUT);
pinMode(10,OUTPUT);
pinMode(11,OUTPUT);
digitalWrite(12,LOW);
digitalWrite(9,LOW);
digitalWrite(10,LOW);
digitalWrite(11,LOW);

Serial.begin(115200);
}

int now = 0;
void loop(){
  
  
  if (Serial.available() > 0 ) {
  
    char TMP = Serial.read();
    now++;
    now = now % COLOR_STEP;
      analogWrite(9,CP_B[now]);
      analogWrite(10,CP_R[now]);
      analogWrite(11,CP_G[now]);
  }

  /*
  analogWrite(9,13);
  analogWrite(10,16);
  analogWrite(11,16);
  */
  


}
