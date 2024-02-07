// See https://aka.ms/new-console-template for more information
using System;

namespace lesson{
    class Program {
        static void Main(){

            int num = 0, num2=0;

            num = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First: " + num + ". Second: " + num2);

            double x = 3.251;
            double y = 0.325;
            double z = 0.466e-4; // 0.466 * 10^(-4)
            double c = 4.025;

            double result = c * (2 + 3 - 1) * (Math.PI * Math.Atan(z) - x + y * y + 1);

            Console.WriteLine("Результат выражения: " + result);
            // Numbers:
            // uint number = 10;
            // byte byte_num = 255;
            // short short_num = 32767;
            // long long_num = 900;

            // Numbers with point:
            // float num_float = 4.35f;
            // double num_double = 4.32323434d;

            //String
            // string world = "Переменная";
            // char symbol = 'S';

            // Bool:
            // bool is_active = true;
            // is_active = false;

            // Console.WriteLine(number);
            // number = 10;
            // Console.WriteLine(number);
            // number = 12;
            // Console.WriteLine(number);
            // Console.WriteLine(number);
            // Console.WriteLine("Hello Meder!");
            // Console.Write("Hello2!\n\n");
            // Console.Write("Hello3!\n");
            // Console.ReadLine();
        }
    }
}
