#include <SoftwareSerial.h>
SoftwareSerial RS485(3,4);

const byte _digitalOUT_Start = 8;
const byte _digitalOUT_End = 13;
const byte _digitalIN_Start = 5;
const byte _digitalIN_End = 7;
const byte _analogIN_Start = 0;
const byte _analogIN_End = 5;

#define _slaveID 01

byte frame[64];
bool receiveComplete = false;

unsigned int calculateCRC(unsigned char bufferSize);
void process_Func01();
void process_Func02();
void process_Func03();
void process_Func04();
void process_Func05();
void process_Func06();

int getStartAddress();
int getNumberOfCoil();
bool checkPin_Func(int, int, byte, byte);
int getNumberOfData_Res(int);



void setup() {
//  dht.begin();
  //Serial.begin(9600);
  RS485.begin(9600);

  

  for (int i = 5;i<=7;i++)
    pinMode (i,INPUT);
 
  for (int i = 8;i<=13;i++)
  {  pinMode (i,OUTPUT);
   //  digitalWrite(i,HIGH);
  }
    digitalWrite (12,LOW);
}

void loop() {
  Modbus_update();
  if(receiveComplete == true){
    receiveComplete = false;

    unsigned int crcCal;
    byte crc[2];
    crcCal= calculateCRC(6);
    crc[0] = (byte)((crcCal >> 8)& 0xFF);
    crc[1] = (byte)crcCal &0xFF;
 
    if(crc[0] == frame[6] && crc[1] == frame[7])
    {
      if(frame[0] == 01)
        switch (frame[1])
        {
          case 01: process_Func01();
          break;
          case 02: process_Func02();
          break;
          case 03: process_Func03();
          break;
          case 04: process_Func04();
          break;
          case 05: process_Func05();
          break;
          case 06: process_Func06();
          break;
          
          default: 
          {
            frame[1] |= 0x80;
            frame[2] = 01;  //exception function 01: Illegal Function

            unsigned int crcCal;
            crcCal= calculateCRC(3);
            frame[3] = (byte)((crcCal >> 8) & 0xFF);
            frame[4] = (byte)crcCal & 0xFF;
              digitalWrite (12,HIGH);
            for(int i = 0; i<5; i++)
              RS485.write(frame[i]);
              digitalWrite (12,LOW);
          }
        }    
    }     
  }
}

void Modbus_update()
{
  if(RS485.available())
  {
    
    while(RS485.available())
    {
      RS485.readBytes(frame,8);      
      receiveComplete = true;
    }     
  }  
  delayMicroseconds(1562);
}

unsigned int calculateCRC(unsigned char bufferSize) 
{
  unsigned int temp,temp1, temp2, CRCLSB;
  temp = 0xFFFF;
  for (unsigned char i = 0; i < bufferSize; i++)
  {
    temp = temp ^ frame[i];
    for (unsigned char j = 1; j <= 8; j++)
    {
      CRCLSB = temp & 0x0001;
      temp >>= 1;
      if (CRCLSB == 1)
        temp ^= 0xA001;
    }
  }

  temp2 = temp >> 8;
  temp1 = temp <<8;
  temp = temp1 | temp2;
  temp &= 0xFFFF;
  return temp;   
}

/* FUNCTION 01:
 * READNG THE ON/OFF STATUS OF DISCRETE OUTPUTS
 * ID(1) FUNCTION(1) ADDRESS(2) NUMBER_OF_COIL(2) CRC(2)
 */ 
void process_Func01()
{
  int _startAddress = getStartAddress();
  int _numberOfCoil = getNumberOfCoil();
  int _numberOfData = getNumberOfData_Res(_numberOfCoil);
  if (checkPin_Func(_startAddress,_numberOfCoil,_digitalOUT_Start,_digitalOUT_End) == true)
    {
      char binData[8]={0,0,0,0,0,0,0,0};
      byte hexData =0;
      for (int i=_startAddress, j=7;i<(_startAddress+_numberOfCoil); i++, j--)
      {
        binData[j]= digitalRead(i);
      }
      for ( int i=7; i >=0; --i )
      {
        hexData |= (binData[i] << (7-i));
      }
      frame[0] = _slaveID;
      frame[1] = 01;
      frame[2] = _numberOfData;
      frame[3] = hexData;
      unsigned int crcCal;
      crcCal= calculateCRC(4);
      frame[4] = (byte)((crcCal >> 8) & 0xFF);
      frame[5] = (byte)crcCal & 0xFF;
        digitalWrite (12,HIGH);
      for(int i = 0;i<=5;i++)
       RS485.write(frame[i]);
         digitalWrite (12,LOW);
   }
   else
   {
      frame[1] |= 0x80;
      frame[2] = 02;  //exception function 02: Illegal Adress Value

      unsigned int crcCal;
      crcCal= calculateCRC(3);
      frame[3] = (byte)((crcCal >> 8) & 0xFF);
      frame[4] = (byte)crcCal & 0xFF;
        digitalWrite (12,HIGH);
      for(int i = 0; i<5; i++)
        RS485.write(frame[i]);
          digitalWrite (12,LOW);
   } 
}

/* FUNCTION 02:
 * READNG THE ON/OFF STATUS OF DISCRETE INPUTS
 * ID(1) FUNCTION(1) ADDRESS(2) NUMBER_OF_COIL(2) CRC(2)
 */ 
void process_Func02()
{
  int _startAddress = getStartAddress(); 
  int _numberOfCoil = getNumberOfCoil();
  int _numberOfData = getNumberOfData_Res(_numberOfCoil);
  if (checkPin_Func(_startAddress,_numberOfCoil,_digitalIN_Start,_digitalIN_End) == true)
    {
      char binData[8]={0,0,0,0,0,0,0,0};
      byte hexData =0;
      for (int i=_startAddress, j=7;i<(_startAddress+_numberOfCoil); i++, j--)
      {
        binData[j]= digitalRead(i);
      }
      for ( int i=7; i >=0; --i )
      {
        hexData |= (binData[i] << (7-i));
      }
      frame[0] = _slaveID;
      frame[1] = 02;
      frame[2] = _numberOfData;
      frame[3] = hexData;
      unsigned int crcCal;
      crcCal= calculateCRC(4);
      frame[4] = (byte)((crcCal >> 8) & 0xFF);
      frame[5] = (byte)crcCal & 0xFF;
       digitalWrite (12,HIGH);
      for(int i = 0;i<=5;i++)
       RS485.write(frame[i]);
         digitalWrite (12,LOW);
   }
   else
   {
      frame[1] |= 0x80;
      frame[2] = 02;  //exception function 02: Illegal Address Value

      unsigned int crcCal;
      crcCal= calculateCRC(3);
      frame[3] = (byte)((crcCal >> 8) & 0xFF);
      frame[4] = (byte)crcCal & 0xFF;
        digitalWrite (12,HIGH);
      for(int i = 0; i<5; i++)
        RS485.write(frame[i]);
          digitalWrite (12,LOW);
   }  
}
/* FUNCTION 03
 * READ HOLDING REGISTER
 * REQUEST: ID(1) FUNCTION CODE(2) START ADDRESS(3,4) NUMBER OF REGISTER(5,6) CRC(7,8)
 * RESPONSE:ID(0) FUNCTION CODE(1) NUMBER OF DATA(2) CONTENT OF REGISTER(NumberOfData*2) CRC
 * DHT11: HUMIDITY PIN 4
 */
void process_Func03()
{
 /*int _startRegister = getStartAddress();
 int _numberOfRegister = getNumberOfCoil();

 int value = dht.readHumidity();
 EEPROM.write(0xFF,value);
 if (_startRegister>0x00 && _startRegister<0x200 && _startRegister+_numberOfRegister<=0x200)
 {
  int humidity = EEPROM.read(_startRegister);
  EEPROM.write(_startRegister, 0);
  frame[0] = _slaveID;
  frame[1] = 03;
  frame[2] = 02;
  frame[3] = 00;
  frame[4] = humidity;

  unsigned int crcCal;
  crcCal= calculateCRC(5);
  frame[5] = (byte)((crcCal >> 8) & 0xFF);
  frame[6] = (byte)crcCal & 0xFF;
  
  for(int i = 0; i<7; i++)
    Serial.write(frame[i]);
 }
 else
 {
    frame[1] |= 0x80;
    frame[2] = 02;  //exception function 02: Illegal Address Value

    unsigned int crcCal;
    crcCal= calculateCRC(3);
    frame[3] = (byte)((crcCal >> 8) & 0xFF);
    frame[4] = (byte)crcCal & 0xFF;

    for(int i = 0; i<5; i++)
      Serial.write(frame[i]);
 }  */
}

/* FUNCTION 04:
 * READ THE CONTENT OF ANALOG INPUT
 * ID(1) FUNCTION(1) ADDRESS(2) NUMBER_OF_REGISTER(2) CRC(2)
 */ 
void process_Func04()
{
  int _startAddress = getStartAddress(); 
  int _numberOfCoil = getNumberOfCoil();
  int _numberOfData = _numberOfCoil*2;
  unsigned int data[6];

  if (checkPin_Func(_startAddress,_numberOfCoil,_analogIN_Start,_analogIN_End) == true)
    {
      for(int i = _startAddress;i<(_startAddress+_numberOfCoil);i++)
      {
        int j = 0;
        data[j]  = analogRead(i);
        j++;
        delay(20);
      }
      for(int i = 0,k=0;i<_numberOfCoil;i++,k+2)
      {
       frame[k+3] = (byte)((data[i] >> 8)& 0xFF);
       frame[k+4] = (byte)data[i] &0xFF;
      }
      frame[0] = _slaveID;
      frame[1] = 04;
      frame[2] = _numberOfData;

      unsigned int crcCal;
      crcCal= calculateCRC(_numberOfData+3);
      frame[_numberOfData+3] = (byte)((crcCal >> 8) & 0xFF);
      frame[_numberOfData+4] = (byte)crcCal & 0xFF;
       digitalWrite (12,HIGH);
      for(int i = 0; i<_numberOfData+5; i++)
        RS485.write(frame[i]);
          digitalWrite (12,LOW);
    }
    else
    {
      frame[1] |= 0x80;
      frame[2] = 02;  //exception function 02: Illegal Address Value

      unsigned int crcCal;
      crcCal= calculateCRC(3);
      frame[3] = (byte)((crcCal >> 8) & 0xFF);
      frame[4] = (byte)crcCal & 0xFF;
          digitalWrite (12,HIGH);
      for(int i = 0; i<5; i++)
        RS485.write(frame[i]);
          digitalWrite (12,LOW);
    }  
}

/* FUNCTION 05:
 * WRITING THE CONTENT OF DISCRETE COIL TO ON/OFF
 * ID(1) FUNCTION(1) ADDRESS(2) STATUS(2) CRC(2)
 */ 
void process_Func05(){
  int _address = getStartAddress();
  if (_address >= _digitalOUT_Start && _address <= _digitalOUT_End)
  {
    if(frame[04] == 0xFF)
      digitalWrite(_address,HIGH);
    else 
      digitalWrite(_address,LOW);
    int state = digitalRead(_address);
    if(state == 1)
    {
      frame[4] = 0xFF;
      frame[5] = 0x00;    
    }
    else{
      frame[4] = 0x00;
      frame[5] = 0x00;  
    }
    unsigned int crcCal;
    crcCal= calculateCRC(6);
    frame[6] = (byte)((crcCal >> 8)& 0xFF);
    frame[7] = (byte)crcCal &0xFF;
        digitalWrite (12,HIGH);
    for(int i = 0; i < 8; i++)
      RS485.write(frame[i]);
        digitalWrite (12,LOW);
  }
  else
   {
      frame[1] |= 0x80;
      frame[2] = 02;          //exception function 02: Illegal Address Value

      unsigned int crcCal;
      crcCal= calculateCRC(3);
      frame[3] = (byte)((crcCal >> 8) & 0xFF);
      frame[4] = (byte)crcCal & 0xFF;
       digitalWrite (12,HIGH);
      for(int i = 0; i<5; i++)
        RS485.write(frame[i]);
          digitalWrite (12,LOW);
   } 
}

/*  FUNCTION 06:
 *      ID(1) FUNCTION_CODE(1) ADDRESS(2) DATA(2) CRC(2)
 *      WRITING CONTENT OF ANALOG INPUT HOLDING RESGISTER
 *      PWM PIN: 9,10,11
 */
void process_Func06()
{
  int _address = getStartAddress(); 
  int _value = getNumberOfCoil();
  if (_address == 9 || _address == 10 || _address == 11)
  {
    
    analogWrite(_address,50);
    //delay(7000);
    //analogWrite(_address, 0);
      
    unsigned int crcCal;
    crcCal= calculateCRC(6);
    frame[6] = (byte)((crcCal >> 8) & 0xFF);
    frame[7] = (byte)crcCal & 0xFF;
      digitalWrite (12,HIGH);
    for(int i=0;i<8;i++)
      RS485.write(frame[i]);
        digitalWrite (12,LOW);
    
  }
  else
  {
    frame[1] |= 0x80;
    frame[2] = 02;              //exception function 02: Illegal Address Value

    unsigned int crcCal;
    crcCal= calculateCRC(3);
    frame[3] = (byte)((crcCal >> 8) & 0xFF);
    frame[4] = (byte)crcCal & 0xFF;
     digitalWrite (12,HIGH);
    for(int i = 0; i<5; i++)
      RS485.write(frame[i]);
        digitalWrite (12,LOW);
   } 
}
      

/* FUNCTION getStartAddress():
 *    FUNCTION CODE: 1,2,4,5,15
 *    GET START ADDRESS
 */
int getStartAddress()
{ 
  int result;
  unsigned char value1 = (unsigned char)(frame[2]);
  unsigned char value2 = (unsigned char)(frame[3]);
  result = (int)(value1 <<8 | value2);
  return result;
}

/* FUNCTION getNumberOfCoil():
 *    FUNCTION CODE: 1,2,4,15
 *    GET NUMBER OF COIL
 */
int getNumberOfCoil()
{
  int result;
  unsigned char value1 = (unsigned char)(frame[4]);
  unsigned char value2 = (unsigned char)(frame[5]);
  result = (int)(value1 <<8 | value2);
  return result;
}

int getNumberOfData_Res(int numberOfCoil)
{
    int val1 = numberOfCoil/8;
    int val2 = numberOfCoil%8;

    if(val2 == 0)
      return val1;
    else 
      return val1 + 1;
}

/* FUNCTION CheckPin_Func:
 * CHECK THE COIL REQUEST THAT INSIDE THE COIL RANGE
 *      DIGITAL OUT PIN: 8-->13
 *      DIGITAL IN PIN:  3-->7
 *      ANALOG OUT PIN:  0-->5
 * Parameter:
 *      startAddress: get from request frame.
 *      numberOfCoil: get from request frame.
 *      _start:       start pin in arduino.
 *      _end:         end pin in arduino.
 */ 
bool checkPin_Func (int startAddress, int numberOfCoil, byte _start, byte _end )
{
  if((startAddress >= _start) && (startAddress <= _end) && (startAddress+numberOfCoil-1) <= _end && numberOfCoil != 0)
    return true;
  else 
    return false;  
}


