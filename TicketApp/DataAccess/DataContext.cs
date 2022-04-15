using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext
    {
        public static List<Ticket> Tickets { get; set; }
        static DataContext()
        {
            Tickets = new List<Ticket>();
        }
    }
}
