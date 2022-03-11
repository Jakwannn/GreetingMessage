using System;

namespace GreetingMessage
{
    /// <summary>
    /// main class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Greet("Naufal Dzakwan");
            Console.WriteLine(msg);

            Console.ReadKey();
        }
        /// <summary>
        /// Menampilkan pesan yang berupa nama
        /// </summary>
        /// <param name="name">Target nama</param>
        /// <returns>Pesan nama</returns>
        static string Greet(string name)
        {
            string msg = $"Hello {name}!";
            return msg;
        }
    }
}
