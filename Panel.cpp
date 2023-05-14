#include <FastLED.h>
#include "Snake.cpp"
#include "Shining.cpp"

#define WIDTH 20
#define HEIGHT 9
#define NUM_LEDS WIDTH * HEIGHT

#define DATA_PIN 2

CRGB leds[NUM_LEDS];

void setup() {
    // To run once 
    FastLED.addLeds<WS2812B, DATA_PIN, GRB>(leds, NUM_LEDS);
}

void loop() {
    doShining();
    doSnake();
}

void doShining() {
    Shining shining(leds, WIDTH, HEIGHT, true, true);
    Shining.start();
}

void doSnake() {
    Snake snake(leds, WIDTH, HEIGHT);
    snake.start();
}

// For now, unfortunately the snake doesn't work
