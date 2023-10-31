#include <string.h>
#include <stdlib.h>
#include "HX710.h"




////////////////////////////////////////////////////////////////
// PARAMETERS
////////////////////////////////////////////////////////////////

const int DOUT = 10;
const int PD_SCK = 13;

#define SERIAL_PLOTTER



////////////////////////////////////////////////////////////////
// SETUP
////////////////////////////////////////////////////////////////

HX710 ps;

void setup() {
    Serial.begin( 9600 );
    ps.initialize( PD_SCK , DOUT );


}
bool readStringUntil(String& input, char until_c, size_t char_limit) {
  while (Serial.available()) {
    char c = Serial.read();
    input += c;
    if (c == until_c) {
      return true;
    }
    if (input.length() >= char_limit) {
      return true;
    }
  }
  return false;
}



////////////////////////////////////////////////////////////////
// LOOP
////////////////////////////////////////////////////////////////

void loop() {
    int32_t value;
    int32_t bar;

  

    
    while( !ps.isReady() );

    ps.readAndSelectNextData( HX710_DIFFERENTIAL_INPUT_40HZ );
    value = ps.getLastDifferentialInput();
  
if(value <= -141581){
 bar = map(value, -1415815, -8388608, 0, -100);
}else if(value <= 2520030){
  bar = map(value, -1415815, 2520030, 0, 100);
}else if(value > 2520030){
  value = 100;
}
    


    
#ifdef SERIAL_PLOTTER
Serial.println(bar);

//   if(sip <= -50){
// Serial.println("hard sip");

//   }else if(sip > -50 && sip < -5){
// Serial.println("soft sip");

//   }else if(puff > 5 && puff < 30){
// Serial.println("soft puff");

//   }else if(puff >= 20){
// Serial.println("hard puff");

//   }else
// Serial.println("nothing");

#else
    Serial.print( "differential input (40 Hz): " );
    Serial.println( percent );
#endif
}


