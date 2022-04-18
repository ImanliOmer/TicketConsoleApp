using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace TicketApp.Controller
{
    public class ITicketController
    {
        private ITicketService ticketService;
        public ITicketController()
        {
            ticketService = new ITicketService();
        }

        public void CreatTicket()
        {
            EnterName:
            Extentions.Print(ConsoleColor.Green, $"Ticket Name");
            string name = Console.ReadLine();

            Extentions.Print(ConsoleColor.Green, $"go time");
            string hours = Console.ReadLine();


            Extentions.Print(ConsoleColor.Green, $"cost ");
            string cost = Console.ReadLine();



         
            if (true)
            {
                Ticket ticket = new Ticket
                {
                    Where = name,
                     
                };

                ticketService.Create(ticket);
                Extentions.Print(ConsoleColor.Green, $"{ticket.Where} created");

            }
            else
            {
                Extentions.Print(ConsoleColor.Red, "Duzgun daxil et");
                goto EnterName;
            }

        }
        public void GetAllTicket()
        {

            foreach (var item in ticketService.GetAll())
            {
                Extentions.Print(ConsoleColor.Yellow, $"{item.Where}");
            }
        }

        public  void RemoveTicket()
        {
            Extentions.Print(ConsoleColor.Yellow, $"Silmek istenilen Id:");
            int id = int.Parse(Console.ReadLine());
            Extentions.Print(ConsoleColor.Green, $"{ticketService.Delete(id).Where}");

        }


        public void GetOneTicket()
        {
            Extentions.Print(ConsoleColor.Yellow, $"Id daxil edi:");
            int id = int.Parse(Console.ReadLine());
            Extentions.Print(ConsoleColor.Blue, $"{ticketService.GetTicket(id).Where}");
        }









    }
}
