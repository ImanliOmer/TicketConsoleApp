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


            Extentions.Print(ConsoleColor.Green, $"cost time");
            string cost = Console.ReadLine();



            Extentions.Print(ConsoleColor.Green, $"Group Size");
            string ticketSize = Console.ReadLine();
            int size;


            bool isSize = int.TryParse(ticketSize, out size);
            if (isSize)
            {
                Ticket ticket = new Ticket
                {
                    Where = name,
                    MaxSize = size,
                  
                };

                ticketService.Create(ticket);
                Extentions.Print(ConsoleColor.Green, $"{ticket.Where} created");
                ticketService.Create(ticket);
                Extentions.Print(ConsoleColor.Green, $"{ticket.Hours} go time");
                ticketService.Create(ticket);
                Extentions.Print(ConsoleColor.Green, $"{ticket.Cost} cost");
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
            int id = int.Parse(Console.ReadLine());
            Extentions.Print(ConsoleColor.Green, $"{ticketService.Delete(id).Where}");

        }


    }
}
