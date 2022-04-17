using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public static class Extentions
    {
        public static void Print(ConsoleColor color,string message)
        {

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum Menu
        {
            CreateTicket = 1,
            RemoveTicket,
            GetTicket,
            GetAllTicket = 4
            
        }
    }
}
