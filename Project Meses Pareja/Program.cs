using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Meses_Pareja
{
    class Program
    {
        static void Main(string[] args)
        {
            int month,randYear1,randYear2,year;
            Console.WriteLine("Escribe el mes");
            month = Int32.Parse(Console.ReadLine());
            CheckMonth(month);
            Console.WriteLine("Escriba dos años entre los que generar uno aleatorio");
            randYear1 = Int32.Parse(Console.ReadLine());
            randYear2 = Int32.Parse(Console.ReadLine());
            year = Year(randYear1, randYear2);
            Console.WriteLine("El año generado es " + year);

            
            Console.ReadKey();
        }
        public static int CheckMonth(int month)
        {
            int count = 0;
            do
            {
                if (count >0)
                {
                    Console.WriteLine("El número de mes no es correcto, introduzca de nuevo");
                    month = Int32.Parse(Console.ReadLine());               
                }
                count = count + 1;
            } while (month < 1 || month > 12);
            return month;
        }
        public static int Year(int randYear1,int randYear2)
        {
            int year;
            Random random = new Random();
            if (randYear2 > randYear1)
            {
                year = random.Next(randYear1, randYear2);//Max value al final  
            }
            else
            {
                year = random.Next(randYear2, randYear1);
            }
            return year;
        }

    }
}
