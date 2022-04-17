using Business.Services;
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
                ITicketController ticketController = new ITicketController();
                Extentions.Print(ConsoleColor.Cyan, "1-Create Ticket\n" +
                    "2-Update Ticket\n" +
                    "3-Remove Ticket\n" +
                    "4-Get Ticket\n" +
                    "5-GetAll Ticket");

                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);

                if (IsNum && input < 7 && input > 0)
                {
                    switch (input)
                    {
                        case (int)Extentions.Menu.CreateTicket:
                            ticketController.CreatTicket();
                            break;
                        case 2:
                            break;

                        case (int)Extentions.Menu.RemoveTicket:
                            ticketController.RemoveTicket();
                            break;

                        case 4:
                            break;

                        case (int)Extentions.Menu.GetAllTicket:
                            ticketController.GetAllTicket();
                            break;
                    }
                }



            }
        }
    }
}
