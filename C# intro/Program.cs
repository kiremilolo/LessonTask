using System;

namespace C__intro
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("=====================================");

            //    - Verilmiş dəyər "salam"-dırsa "aleykum salam",
            //    "sag ol"-dursa "sen de sag ol" əks halda "Men bu dili bilmirem:( " yazdıran proqram


            //Console.WriteLine("Deyr yazin: ");

            //string deyer = Console.ReadLine();

            //if(deyer == "Salam")
            //{
            //    Console.WriteLine("Ayleykum Salam");
            //}
            //else if(deyer == "Sagol")
            //{
            //    Console.WriteLine("Sen de sagol");
            //}
            //else
            //{
            //    Console.WriteLine("Men bu dili bilmiyorum :(");
            //}

            ////Verilmiş dəyərin həftənin hansı günü olduğunu tapan proqram








            //Verilmiş 2 ədəd üzərində verilmiş operator simvoluna uyğun riyazi əməliyyat aparan proqram.
            //Misalçün consoledan 5,10 və + daxil edilsə 5 və 10-u toplayıb nəticəsini göstərsin.
            //Console-dan daxil edilən operator + , -, *, / operatorlarından biri deyilsə operator yanlışdır yazılsın.

            //ctrl+k, ctrl+D

            //Console.WriteLine("1 reqemi daxil et");
            //string num1 = Console.ReadLine();
            //Console.WriteLine("2 reqemi daxil et");
            //string num2 = Console.ReadLine();

            //int num1Convert = Convert.ToInt32(num1);
            //int num2Convert = Convert.ToInt32(num2);

            //Console.WriteLine("Operatoru daxil et");
            //var op = Console.ReadLine();



            //if (op == "+")
            //{
            //    var sum = num1Convert + num2Convert;
            //    Console.WriteLine(sum);
            //}
            //else if (op == "-")
            //{
            //    int minus = num1Convert - num2Convert;
            //    Console.WriteLine(minus);
            //}
            //else if (op == "*")
            //{
            //    var mp = num1Convert * num2Convert;
            //    Console.WriteLine(mp);
            //}
            //else if (op == "/")
            //{
            //    var dv = num1Convert / num2Convert;
            //    Console.WriteLine(dv);
            //}
            //else
            //{
            //    Console.WriteLine("Operator yanlisdir");
            //}






















            //Console.WriteLine("Heftenin gununu daxil edin");
            //var day = Console.ReadLine();

            //int daynumber = Convert.ToInt32(day);



            Console.WriteLine("Gunu daxil edin");
            string day = Console.ReadLine();




            switch (day)
            {

                case "1":
                    Console.WriteLine("1 Gun");
                    break;
                case "2":
                    Console.WriteLine("2 Gun");
                    break;
                case "3":
                    Console.WriteLine("3 Gun");
                    break;
                case "7":
                    Console.WriteLine("Heftesou");
                    break;
                case "8":
                    Console.WriteLine("Heftesonu");
                    break;
                default:
                    Console.WriteLine("Deyer yanlisdir");
                    break;
            }





        }
    }
}
