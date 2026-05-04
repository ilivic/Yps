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
        /// <summary>
        /// Приватная переменная, хранящая информацию об введённом выражений
        /// </summary>
        private static string _key {  get; set; }
        /// <summary>
        /// Приватная переменная, отвечающая за счет времени таймера 
        /// </summary>
        private static int _t {  get; set; }
        /// <summary>
        /// Лист логирования
        /// </summary>
        private static List<log> _log {  get; set; }
        static void Main(string[] args)
        {
            _log = new List<log>();
            _key = "";
            answer();
        }
        private static void Logger(string body)
        {
            _log.Add(new log()
            {
                date = DateTime.Now,
                rez = body,
                key = _key,
            });
            Console.WriteLine(body);
        }
        /// <summary>
        /// Метод обработки ввода данных
        /// </summary>
        private static void answer()
        {
            switch (_key.ToLower())
            {
                case "":
                    {
                        Logger("Всё хорошо");
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "привет":
                    {
                        Logger("Привееет Как ты?)");
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "сколько время":
                    {
                        Logger("Сейчас" + DateTime.Now);
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "запусти секундомер":
                    {
                        Logger("запустил");
                        Task.Run(Ctimer);
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "сколько прошло":
                    {
                        Logger(_t.ToString());
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "заверши":
                    {
                        Logger("Завершил");
                        _t = -1;
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                case "история":
                    {
                        Logger("вывожу историю чата");
                        Task.Run(()=> ShowHist());
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
                default:
                    {
                        Logger("-------------");
                        _key = Console.ReadLine();
                        answer();
                        break;
                    }
            }
        }
        /// <summary>
        /// Метод вывода логов
        /// </summary>
        private static async void ShowHist()
        {
            foreach (var item in _log.ToList())
            {
                Console.WriteLine(item.key+" ");
                Console.Write(item.rez+ " ");
                Console.Write(item.date+ " ");
            }
        }
        /// <summary>
        /// Метод имитирующий таймер (асинхронный)
        /// </summary>
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

        private class log
        {
            public string key { get; set; } 
            public string rez { get; set; } 
            public DateTime date { get; set; } 
        }

    }
}
