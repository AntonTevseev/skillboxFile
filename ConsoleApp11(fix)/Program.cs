using System;
using static System.Console;
using System.Threading;
using System.IO;

namespace xuy
{
    class Program
    {

        static void Main(string[] ages)
        {
           
            StreamWriter sw = new StreamWriter("new.txt",true);

            string key; 

            string note = string.Empty;
            
            while(true)
            {
                Write("Если хотите вывести информацию на экран нажмите 1, если хотите продолжить нажмите 2");
                key = ReadLine();
                if (key == "1") { Write(note); break; }

                else
                {
                    Write("\nВведите ID ");
                    note += $"{ReadLine()}\t";

                    Write("\nВведите Ф И О ");
                    note += $"{ReadLine()}\t";

                    Write("\nВведите ваш возраст");
                    note += $"{ReadLine()}\t";

                    Write("\nВведите ваш рост ");
                    note += $"{ReadLine()}\t";

                    Write("\nВведите ваш возраст ");
                    note += $"{ReadLine()}\t";

                    Write("\nВведите ваше место рождения ");
                    note += $"{ReadLine()}\t";

                    string now = DateTime.Now.ToShortTimeString();
                    note += $"{now}\t";

                    sw.Write(note);
                }

                
               
            }
            
            

        }
    }
}
