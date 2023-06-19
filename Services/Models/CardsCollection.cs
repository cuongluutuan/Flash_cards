using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class CardsCollection
    {
        public CardsCollection() 
        {
            CardEntries = new HashSet<CardEntry>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<CardEntry> CardEntries { get; set;}
    }
}
