using Business.Services;
using Entities.Models;
using System;
using TicketApp.Controller;
using Utilities.Helper;

namespace TicketApp
{
    internal class Program
    {
        private static ITicketService _ticketService;
        public Program()
        {
            _ticketService = new ITicketService();
        }

        static void Main(string[] args)
        {
            Extentions.Print(ConsoleColor.Green, "Welcome");
            while (true)
            {
                Extentions.Print(ConsoleColor.Cyan, "1-Create Ticket\n" +
                    "2-Update Group\n" +
                    "3-Remove Group\n" +
                    "4-Get Group");
              
                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);

                if (IsNum && input < 7 && input > 0)
                {
                    switch (input)
                    {
                        case (int)Extentions.Menu.CreateTicket:
                            TicketController.Creat();
                            break;
                        case 2:
                            break;
                        case (int)Extentions.Menu.RemoveTicket:
                            TicketController.RemoveTicket();
                            break;
                        case 4:
                            break;
                        case (int)Extentions.Menu.GetAllTicket:
                            TicketController.GetAllTicket();
                            break;
                    }
                }



            }
        }
    }
}
