using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");

            byte b = 5;     //1 byte
            sbyte sb = 5;   //1 byte

            short s = 5;    //2 byte
            ushort us = 5;  //2 byte

            Int16 i16 = 2;  //2 byte
            int i = 2;      //4 byte
            Int32 i32 = 2;  //4 byte
            Int64 i64 = 2;  //8 byte

            uint ui = 2;    //4 byte
            long l = 4;     //8 byte
            ulong ul = 4;   //8 byte

            //reel sayılar
            float f = 5;          //4 byte 
            double d = 5;         //8 byte 
            decimal de = 5;       //16 byte

            char c = '2';         //2 byte
            string str = "selam"; //sınırsız

            bool bl = true;  

            DateTime dt = DateTime.Now;   

            //her türlü veri object veri tipine atanabilir. 

            //Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString(); //çıktı 2020

            int intyeni = int20 + Convert.ToInt32(str20); //çıktı 40

            //DateTime
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");

            //hour
            string hour = DateTime.Now.ToString("HH:mm");
        }
    }
}
