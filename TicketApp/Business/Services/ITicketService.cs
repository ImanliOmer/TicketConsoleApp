using Business.Interface;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ITicketService : ITicket
    {
        public static int Count { get; set; }
        private TicketRepo _ticketRepo;
        public ITicketService()
        {
            _ticketRepo = new TicketRepo();
        }

        public Ticket Create(Ticket ticket)
        {

            ticket.Id = Count;

            _ticketRepo.Create(ticket);
            Count++;
            return ticket;

        }

        public Ticket Delete(int Id)
        {
            Ticket isExist = _ticketRepo.GetOne(t => t.Id == Id);
            if (isExist == null)
            {
                return null;
            }
            _ticketRepo.Delete(isExist);
            return isExist;
        }

        public Ticket GetTicket(string name)
        {
            return _ticketRepo.GetOne(g => g.Where == name);
        }

        public Ticket Update(int Id, Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> GetAll()
        {
            return _ticketRepo.GetAll();
        }

        public Ticket GetTicket(int id)
        {
            return _ticketRepo.GetOne(t => t.Id == id);
        }
        public List<Ticket> GetAll(string name = null)
        {
            return _ticketRepo.GetAll(t=>t.Where == name);
        }

        public Ticket GetTickett(string where)
        {
            return _ticketRepo.GetOne(t=>t.Where == where);
        }
    }
}
