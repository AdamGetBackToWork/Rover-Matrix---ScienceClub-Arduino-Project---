#include <FastLED.h>
#include "Snake.cpp"
#include "Twinkle.cpp"

#define WIDTH 20
#define HEIGHT 5
#define NUM_LEDS WIDTH * HEIGHT

#define DATA_PIN 3

CRGB leds[NUM_LEDS];

void setup() {
  // put your setup code here, to run once:

    FastLED.addLeds<WS2812B, DATA_PIN, GRB>(leds, NUM_LEDS);
}

void loop() {
    doTwinkle();
    doSnake();
}

void doTwinkle() {
    Twinkle twinkle(leds, WIDTH, HEIGHT, true, true);
    twinkle.start();
}

void doSnake() {
    Snake snake(leds, WIDTH, HEIGHT);
    snake.start();
}
