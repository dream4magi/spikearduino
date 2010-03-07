const int MIN_PIN = 2;
const int MAX_PIN = 7;
const int MIN_PORT = 1;
const int MAX_PORT = 6;
char BUFFER[100];
int BUFFER_INDEX = 0;
char TMP;


void setup()  { 

    Serial.begin(115200);
      pinMode(2, OUTPUT);
      pinMode(3, OUTPUT);
      pinMode(4, OUTPUT);    
      digitalWrite(2,LOW);
} 

void loop()  {

  if (Serial.available() > 0) {
    char TMP = Serial.read();
    if (TMP=='1'){
      digitalWrite(4,HIGH);    
      delay(1000);
      digitalWrite(4,LOW);    
    }else if(TMP=='2') {
      digitalWrite(3,HIGH);    
      delay(200);
      digitalWrite(3,LOW);      
    }
  
  }
  
}
