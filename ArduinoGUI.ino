#include <Adafruit_NeoPixel.h>
#ifdef __AVR__
#include <avr/power.h> 
#endif
#define PIN 6 
#define NUMPIXELS 32
Adafruit_NeoPixel pixels(NUMPIXELS, PIN, NEO_GRB + NEO_KHZ800);
#define DELAYVAL 500



String data;
char d1;
String x;
int ledval;

void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  pixels.begin();
}


void loop() {

  pixels.clear();

  if(Serial.available()){
    data = Serial.readString();

    d1 = data.charAt(0);


    switch(d1){

      case 'F':
        digitalWrite(13, HIGH);
      break;

      case 'f':
        digitalWrite(13, LOW);
      break;

      case 'A':
        for(int i=0; i<NUMPIXELS; i++) {
          pixels.setPixelColor(i, pixels.Color(0, 150, 0));
          pixels.show();  
          delay(500);
          pixels.clear();
        }
      break;
      
      case 'B': 
        pixels.setPixelColor(16, pixels.Color(0, 0, 150));
        pixels.clear();
      break;

      case 'S':
        x = data.substring(1);
        ledval = x.toInt();

      break;
    }
  }
}
