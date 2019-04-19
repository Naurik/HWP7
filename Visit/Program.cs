using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите два раза пробел чтобы зафиксировать время входа!");
            ConsoleKeyInfo pressed;
            DateTime now = DateTime.Today;
            pressed = Console.ReadKey();
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                now = DateTime.Now;
            }
            bool fullInformation = true;
            Console.WriteLine("Введите ФИО посетителя:");
            string fullName = Console.ReadLine();
            while (fullInformation)
            {
                if (String.IsNullOrEmpty(fullName) || fullName == "\n")
                {
                    Console.WriteLine("ОШИБКА! Введите ФИО!!!");
                    fullName = Console.ReadLine();
                }
                else { fullInformation = false; }
            }

            Console.WriteLine("Введите причину посещения:");
            string cause = Console.ReadLine();
            while (!fullInformation)
            {
                if (String.IsNullOrEmpty(cause) || cause == "\n")
                {
                    Console.WriteLine("ОШИБКА! Введите причину!!!");
                    cause = Console.ReadLine(); 
                }
                else { fullInformation = true; }
            }

            Console.WriteLine("Введите номер уд. личности:");
            string idVisiters = Console.ReadLine();
            while (fullInformation)
            {
                if (String.IsNullOrEmpty(idVisiters) || idVisiters == "\n")
                {
                    Console.WriteLine("ОШИБКА! Введите номер уд. личности!!!");
                    idVisiters = Console.ReadLine();
                }
                else
                {
                    fullInformation = false;
                }
            }

            Console.WriteLine("Нажмите два раза пробел чтобы зафиксировать время выхода!");
            ConsoleKeyInfo pressedSecond;
            DateTime endVisit = DateTime.Today;
            pressedSecond = Console.ReadKey();
            
            
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                endVisit = DateTime.Now;
            }
            var visitPerson = new VisitProperties
            {
                EntryTime = now,
                ExitTime = endVisit,
                FullName = fullName,
                VisitCause = cause,
                NumberIdentity = idVisiters
            };

            using (var context = new SecondChance())
            {
                context.Vistits.Add(visitPerson);
                context.SaveChanges();
            }
        }
    }
}
