using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Ticket:IEntity
    {
        public int Id { get; set; }
        public string Where { get; set; }
        public int Cost { get; set; }
        public int Hours { get; set; }
        public int MaxSize { get; set; }

    }
}
