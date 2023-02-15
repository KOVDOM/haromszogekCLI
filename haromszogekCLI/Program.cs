using System;
using System.Collections.Generic;
using System.IO;

namespace haromszogekCLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<haromszogadatok> list = new List<haromszogadatok>();
            StreamReader sr = new StreamReader("haromszogek.csv");

            Console.WriteLine("Derékszögűháromszögek:");
            while(!sr.EndOfStream)
            {
                haromszogadatok haromszog=new haromszogadatok(sr.ReadLine());
                list.Add(haromszog);
                if (derekszog(haromszog)==true)
                {
                    Console.WriteLine(haromszog.a);
                }
            }

            sr.Close();

            Console.WriteLine("A,B,C oldal: ");
            foreach (var item in list)
            {
                Console.WriteLine(item.a+" "+item.b+" "+item.c);
            }

            int legnagyobb = 0;
            haromszogadatok legnagyobbharomszog = list[0];
            foreach (var item in list)
            {
                if (derekszog(legnagyobbharomszog))
                {
                    if (legnagyobb < item.a * item.b / 2)
                    {
                        legnagyobb = item.a * item.b / 2;
                        legnagyobbharomszog = item;
                    }
                }
            }
            Console.WriteLine($"Legnagyobb területű háromszög: {legnagyobb}");
            Console.WriteLine($"Legnagyobb területű háromszög adatai: {legnagyobbharomszog.a} {legnagyobbharomszog.b} {legnagyobbharomszog.c}");

            Console.ReadLine();
        }

        public static bool derekszog(haromszogadatok haromszog)
        {
            if (haromszog.a*haromszog.a+haromszog.b*haromszog.b==haromszog.c*haromszog.c)
            {
                return true;
            }
            return false;
        }
    }
}
