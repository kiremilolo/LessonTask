using System;

namespace ArraySelaheddin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool 
            //string
            //int
            //float
            //char

            //index = 0;
            //lenght =1

            //int[] numbers = { 1, 2, 3, 4, 5 };



            string[] cars = { "Mercedes", "BMV", "Mazda", "Volvo", "Opel" };

            for (int i = 0; i < cars.Length; i++) {

                Console.WriteLine(cars[i]);
            }
            //Console.WriteLine(cars.Length);

            Console.WriteLine("Ededi daxil edin");
            var number = Console.ReadLine();    
            var numConv = Convert.ToInt32(number);

            Console.WriteLine(cars[numConv-1]);



            //string employee = "Maksud";

            //string[] employees = { "Huseyn", "Selaheddin", "Hikmet", employee, "Leyla", "Kamran" };


            ////string[] employees = { "Nihad", "Selaheddin", "Huseyn", "Maksud"};


            //Console.WriteLine(employees[3]);


            //var name = employees[3];


            //Console.WriteLine(name);






            


            //Console.WriteLine("\n============\n");

            ////deyer


  

            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Salam");
            //}



            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Salam");
            //}


            ////Array-massiv



        }
    }
}
