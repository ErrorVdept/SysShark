#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <ArduinoJson.h>
#include <EncButton.h>




#define SCREEN_WIDTH 128 // OLED display width, in pixels
#define SCREEN_HEIGHT 64  // OLED display height, in pixels
#define OLED_RESET  -1 // sharing Arduino reset pin
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);


const unsigned char LOGO [] PROGMEM = {
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x40, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x78, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x78, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3e, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xfe, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xff, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x1f, 0x80, 0x00, 0x00, 0x03, 0xff, 0x9c, 0x00, 0x00, 0x00, 0x01, 0xff, 0xff, 0xff, 0xf8, 
	0x00, 0xff, 0xc0, 0x00, 0x00, 0x03, 0xff, 0x9c, 0x00, 0x00, 0x00, 0x01, 0xe0, 0x00, 0x00, 0x0c, 
	0x01, 0xff, 0xc0, 0x00, 0x00, 0x07, 0xff, 0x9c, 0x00, 0x00, 0x00, 0x01, 0xc0, 0x01, 0x00, 0x08, 
	0x03, 0xff, 0xc0, 0x00, 0x00, 0x07, 0xff, 0x1c, 0x00, 0x00, 0x00, 0x01, 0xc0, 0x03, 0x80, 0x18, 
	0x03, 0x80, 0x00, 0x00, 0x00, 0x07, 0x00, 0x1d, 0xc0, 0x1e, 0x00, 0x01, 0xc0, 0x03, 0x80, 0x18, 
	0x03, 0x80, 0x0e, 0x0e, 0x3f, 0xef, 0x00, 0x1f, 0xf0, 0x7f, 0xa2, 0xfd, 0xc3, 0xc1, 0x00, 0x30, 
	0x03, 0xc0, 0x0e, 0x0e, 0x7f, 0xe7, 0x00, 0x1f, 0xf8, 0x7f, 0xe3, 0xfd, 0xc7, 0x80, 0x00, 0x30, 
	0x03, 0xff, 0x0e, 0x0e, 0x7f, 0xc7, 0xfe, 0x1f, 0x78, 0xf1, 0xe3, 0xf9, 0xcf, 0x00, 0x00, 0x60, 
	0x01, 0xff, 0x8e, 0x0e, 0x70, 0x03, 0xff, 0x1c, 0x3c, 0xe0, 0xe3, 0x81, 0xce, 0x00, 0x1f, 0xe0, 
	0x00, 0xff, 0xce, 0x0e, 0x7f, 0x81, 0xff, 0x9c, 0x1d, 0xc0, 0xe3, 0x81, 0xdc, 0x3e, 0x00, 0xc0, 
	0x00, 0x01, 0xce, 0x0e, 0x7f, 0xe0, 0x07, 0x9c, 0x1d, 0xc0, 0xe3, 0x81, 0xfe, 0x60, 0x01, 0xc0, 
	0x00, 0x01, 0xee, 0x0e, 0x3f, 0xe0, 0x03, 0x9c, 0x1d, 0xc0, 0xe3, 0x81, 0xfe, 0x40, 0x01, 0x80, 
	0x00, 0x01, 0xce, 0x1e, 0x00, 0xe0, 0x03, 0x9c, 0x1c, 0xe0, 0xe3, 0x81, 0xff, 0x80, 0x03, 0x00, 
	0x01, 0xff, 0xc7, 0xbe, 0x7f, 0xe3, 0xff, 0x9c, 0x1c, 0xf3, 0xe3, 0x81, 0xe7, 0x80, 0x0e, 0x00, 
	0x01, 0xff, 0xc7, 0xfe, 0x7f, 0xe7, 0xff, 0x1c, 0x1c, 0x7f, 0xe3, 0x81, 0xe3, 0x80, 0x3c, 0x00, 
	0x01, 0xff, 0x83, 0xfe, 0x7f, 0xc7, 0xfe, 0x1c, 0x1c, 0x3f, 0xa3, 0x81, 0xc3, 0xff, 0xf0, 0x00, 
	0x00, 0x00, 0x00, 0xde, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x3c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x01, 0xfc, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x01, 0xf8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x01, 0xe0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x78, 0x00, 0x09, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x60, 0x00, 0x09, 0x10, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x07, 0xa4, 0x43, 0x7f, 0x6d, 0x73, 0xbb, 0x80, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x04, 0xe4, 0x72, 0x49, 0x46, 0x95, 0x25, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x06, 0xa4, 0x42, 0x49, 0x46, 0xd7, 0x25, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x03, 0x9c, 0x7a, 0x46, 0x46, 0x73, 0xb9, 0x80, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
};


void setup() {
  display.begin(SSD1306_SWITCHCAPVCC, 0x3C);
  display.clearDisplay();
  display.display();

  Serial.begin(115200);
  display.setRotation(0);
  display.clearDisplay();

  display.drawBitmap(0, 0,  LOGO, 128, 64, WHITE);
  display.display();
  delay(2000);
  display.clearDisplay();


  display.drawRect(0, 0, 82, 18, WHITE);
    display.display();
    //===============CPU
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(2,2);
    display.println("CPU:");
    display.display();
    //CPU Load
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(44,2);
    display.println("0");
    display.display();
    //CPU Temp
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(82,2);
    display.print("0");
    display.display();
    display.setTextSize(1);
    display.setTextColor(WHITE);
    //display.setCursor(118,2);
    display.print("C");
    display.display();

    //===============GPU
    display.drawRect(0, 20, 82, 18, WHITE);
    display.display();
    //GPU Load
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(2,22);
    display.println("GPU:");
    display.display();

    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(44,22);
    display.println("0");
    display.display();
    //GPU Temp
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(82,22);
    display.print("0");
    display.display();
    display.setTextSize(1);
    //display.setTextColor(WHITE);
    //display.setCursor(118,22);
    display.print("C");
    display.display();

    //=================RAM
    

    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(2,42); //42
    display.println("RAM");
    display.display();
    //s,y,width,height,progress
    drawProgressbar(42,40,81,20, 0 );


    display.fillRect(43, 49, 27, 10, BLACK);
    display.display();

    display.setTextSize(1);
    display.setTextColor(WHITE);
    display.setCursor(44,51); //42
    display.print("0");
    display.print("%");
    display.display();
}

void drawProgressbar(int x,int y, int width,int height, int progress)
{
   progress = progress > 100 ? 100 : progress; // set the progress value to 100
   progress = progress < 0 ? 0 :progress; // start the counting to 0-100
   float bar = ((float)(width-1) / 100) * progress;
   display.drawRect(x, y, width, height, WHITE);
   display.fillRect(x+2, y+2, bar , height-4, WHITE); // initailize the graphics fillRect(int x, int y, int width, int height)
  }



DynamicJsonDocument doc(1024);
int cpuLoad = 0;
int gpuLoad = 0;
int ramLoad = 0;
int cpuTemp = 0;
int gpuTemp = 0;



void drawData(){
    display.clearDisplay();
    display.drawRect(0, 0, 82, 18, WHITE);
    //display.display();
    
    //===============CPU
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(2,2);
    display.println("CPU:");
    //display.display();
    //CPU Load
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(44,2);
    display.println(cpuLoad);
    //display.display();
    //CPU Temp
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(82,2);
    display.print(cpuTemp);
    //display.display();
    display.setTextSize(1);
    display.setTextColor(WHITE);
    //display.setCursor(118,2);
    display.print("C");
    //display.display();

    //===============GPU
    display.drawRect(0, 20, 82, 18, WHITE);
    //display.display();
    //GPU Load
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(2,22);
    display.println("GPU:");
    //display.display();

    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(44,22);
    display.println(gpuLoad);
    //display.display();
    //GPU Temp
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(82,22);
    display.print(gpuTemp);
    //display.display();
    display.setTextSize(1);
    display.setTextColor(WHITE);
    //display.setCursor(118,22);
    display.print("C");
    //display.display();

    //=================RAM
    

    display.setTextSize(2);
    display.setTextColor(WHITE);
    display.setCursor(2,42); //42
    display.println("RAM");
    //display.display();
    //s,y,width,height,progress
    drawProgressbar(42,40,81,20, ramLoad );


    display.fillRect(43, 49, 27, 10, BLACK);
    //display.display();

    display.setTextSize(1);
    display.setTextColor(WHITE);
    display.setCursor(44,51); //42
    display.print(ramLoad);
    display.print("%");
    display.display();
}
void loop() {
//display.clearDisplay();

  if (Serial.available() > 0) {
    deserializeJson(doc, Serial);
    //Serial.println(data);
    cpuLoad = doc["cpuLoad"];
    gpuLoad = doc["gpuLoad"];
    ramLoad = doc["ramLoad"];
    cpuTemp = doc["cpuTemp"];
    gpuTemp = doc["gpuTemp"];

    drawData();
    
  }
    
}
