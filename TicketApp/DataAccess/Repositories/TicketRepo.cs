using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class TicketRepo : IRepositroy<Ticket>
    {
        public bool Create(Ticket entity)
        {
            try
            {
               DataContext.Tickets.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Ticket entity)
        {
            try
            {
                DataContext.Tickets.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }       
        }

        public List<Ticket> GetAll(Predicate<Ticket> filter = null)
        {
            try
            {


                return filter == null ? DataContext.Tickets:
                    DataContext.Tickets.FindAll(filter);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Ticket GetOne(Predicate<Ticket> filter = null)
        {
            try
            {
                return filter == null? DataContext.Tickets[0]:
                    DataContext.Tickets.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Ticket entity)
        {
            try
            {
                Ticket isExist = GetOne(t => t.Id == entity.Id);
                isExist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
