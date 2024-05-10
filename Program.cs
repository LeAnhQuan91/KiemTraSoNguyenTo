using System;

namespace Prime
{

class Program
{
static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Nhap so bat ky: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 2)
                Console.WriteLine(number + " khong phai la so nguyen to");
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                    Console.WriteLine(number + " la so nguyen to");
                else
                    Console.WriteLine(number + " khong phai la so nguyen");
            }
        }
}
}