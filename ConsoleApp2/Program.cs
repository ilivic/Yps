using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private static string _key {  get; set; }
        private static int _t {  get; set; }
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
                case "запусти секундомер":
                    {
                        Console.WriteLine("запустил");
                        Task.Run(Ctimer);
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "сколько прошло":
                    {
                        Console.WriteLine(_t.ToString());
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "заверши":
                    {
                        Console.WriteLine("Завершил");
                        _t = -1;
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
        private static async void Ctimer()
        {
            _t = 0;
            while (true)
            {
                _t++;
                Thread.Sleep(1000);
                if (_t < 0)
                {
                    break;
                }
            }
        }

    }
}
