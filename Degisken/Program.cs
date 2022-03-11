using System;

namespace Degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            byte b = 0;             //0 to 256
            sbyte s = 0;            //-128 to 127

            short sh = 2;           //int16
            int i = 4;              //int32
            long l = 8;             //int64

            uint ui = 444;          //negatif yok

            float f = 4;
            double d = 0.8;
            decimal de = 16;

            char ch = 'a';          //2 byte
            string str = "alfabe";  //yazılan karakter kadar hafızada kullanıcının erişimine alan ayırır.

            bool bo = true;         //false

            object o1 = "abc";
            object o2 = 'a';
            
            DateTime dt = DateTime.Now;
        }
    }
}
