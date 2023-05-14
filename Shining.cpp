#import <Effect.h>

//all occurrences of the identifier "MAX_Shines" in the code will be replaced with the value "25" by the preprocessor.
#define MAX_Shines 25
// Offset for CHSV calculations
#define OFFSET 0xB000

// defining new variable 
typedef struct Shine {
    int x;
    int y;
} Shine;

//  inherits from the "Effect" class (specified in a different file)
class Shining : public Effect {
    

private:
    short numShines;
    bool colour;
    bool cycleSaturation;
    
//    The class takes in an array of CRGB (color) values, the width and height of the LED matrix display, a boolean indicating whether 
//    to use a color cycle, and another boolean indicating whether to cycle the saturation of the colors.
    
public:
    Shining(CRGB *leds, int width, int height, bool colour, bool cycleSaturation) :
        Effect(leds, width, height),
        colour(colour),
        cycleSaturation(cycleSaturation),
        numShines(0) {
    }
    
    
    
//   For each LED, it checks if the LED is currently lit. If the LED is lit, it fades it out by reducing its brightness by 50. 
//   If the LED has completely faded out (brightness is 0), then the number of active shines is decremented.
    
//    "uint" is an abbreviation for "unsigned integer". It is a data type that represents non-negative integer values. 
//    The "uint" data type is usually used as indices into an array, sizes of memory buffers, or counts of objects.
    
    void start() {
        for (uint16_t frame = 0x0000, iterations = 0; iterations < 100; frame += 0x20, iterations++) {
            for (int i = 0; i < width * height; i++) {
                if (leds[i]) {
                    leds[i].fadeToBlackBy(50);
                    if (!leds[i]) {
                        numShines--;
                    }
                } else {
                    if (random(56) == 0) {
                        numShines++;
                        if (colour) {
                            if (cycleSaturation) {
                                //"CHSV" is a color space representation used in the FastLED library
                                // CHSV stands for "Hue, Saturation, Value", and is a cylindrical coordinate representation of a color.
                                
                                uint8_t saturation = (sin16(frame + OFFSET) >> 8) + 128;
                                leds[i] = CHSV(random(255), saturation, 255);
                            } else {
                                leds[i] = CHSV(random(255), random(128, 255), 255);
                            }
                        } else {
                            leds[i] = CRGB::White;
                        }
                    }
                }
            }
            LEDS.show();
        }
    }
};

