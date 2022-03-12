using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama
            int x = 3;
            int y = 2;
            y += 2;     //y = y + 2;

            Console.WriteLine(y);

            x *= 3;

            Console.WriteLine(x);

            //Mantıksal

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Yazmaz");

            if(isSuccess || isCompleted)
                Console.WriteLine("Yazar");

            //İlişkisel

            int a = 3;
            int b = -2;
            bool sonuc = a<b;   //False

            Console.WriteLine(sonuc);
            sonuc = a>b; //True
            Console.WriteLine(sonuc);
            sonuc = a==b; //False
            Console.WriteLine(sonuc);
            sonuc = a<=b; //False
            Console.WriteLine(sonuc);
        }
    }
}
