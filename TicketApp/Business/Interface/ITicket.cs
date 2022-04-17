using Entities.Models;
using System.Collections.Generic;

namespace Business.Interface
{
    public interface ITicket
    {
        Ticket Create(Ticket ticket);

        Ticket Delete(int Id);
        
        Ticket GetTickett(string where);
        
        Ticket GetTicket(int id);

        List<Ticket> GetAll(string name=null);

    }
}
