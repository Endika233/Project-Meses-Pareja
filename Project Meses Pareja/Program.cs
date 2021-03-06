﻿using System;
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
            int month,randYear1,randYear2,year,maxDays,day;
            Console.WriteLine("Escribe el mes");
            month = Int32.Parse(Console.ReadLine());
            month=CheckMonth(month);
            Console.WriteLine("Escriba dos años entre los que generar uno aleatorio");
            randYear1 = Int32.Parse(Console.ReadLine());
            randYear2 = Int32.Parse(Console.ReadLine());
            year = Year(randYear1, randYear2);
            Console.WriteLine("El año generado es " + year);
            maxDays = AskDays(year, month);
            Console.WriteLine("Introduzca un día");
            day = Int32.Parse(Console.ReadLine());
            day=DayCheck(day,maxDays);
            Console.WriteLine("Fecha actual " + day + "/" + month + "/" + year);
            ShowNextDay(day, month, year, maxDays);
        
            

            
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
                year = random.Next(randYear1, randYear2+1);//Max value al final  
            }
            else
            {
                year = random.Next(randYear2, randYear1+1);//Se le suma uno porque coge el maximo-1
            }
            return year;
        }
        public static int AskDays(int year, int month)
        {
            int maxDays;
            if (month == 2 && DateTime.IsLeapYear(year))
            {
                maxDays = 29;
            }
            else if (month == 2 && !DateTime.IsLeapYear(year))
            {
                maxDays = 28;
            }
            else if (month == 3 || month == 6 || month == 9 || month == 11)
            {
                maxDays = 30;
            }
            else
            {
                maxDays = 31;
            }
            return maxDays;
        }
        //Metodo para comprobar maximo dias
        public static int DayCheck(int day,int maxDays)
        {
            do
            {
                if (day > maxDays||day<1)
                {
                    Console.WriteLine("El día introducido no es correcto, introduzca otro");
                    day = Int32.Parse(Console.ReadLine());
                }
            } while (day > maxDays||day<1);
            return day;
        }
        public static void ShowNextDay(int day, int month, int year,int maxDays)
        {
            day = day + 1;
            if (day > maxDays)
            {
                month++;
                day = 1;
                if (month > 12)
                {
                    year = year + 1;
                    month = 1;
                }
            }
            Console.WriteLine("Día siguiente "+ day + "/" + month + "/" + year);
        }

    }
}
