using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private static string _key {  get; set; }
        static void Main(string[] args)
        {
           _key = Console.ReadLine();
            answer();
        }
        private static void answer()
        {
            switch (_key.ToLower())
            {
                case "":
                    {
                        Console.WriteLine("Всё хорошо");
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "привет":
                    {
                        Console.WriteLine("Привееет Как ты?)");
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "сколько время":
                    {
                        Console.WriteLine("Сейчас" + DateTime.Now);
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "кто ты?":
                    {
                        Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                default:
                    {
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
            }
        }

    }
}
