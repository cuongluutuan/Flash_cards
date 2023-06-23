using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class CardEntry
    {

        public int Id { get; set; }
        public int CardsCollectionId { get; set; }
        public string Question { get; set; } = null!;
        public string AnswerSet { get; set; } = null!;
        public string Answer { get; set;} = null!;
        public bool Learned { get; set; }

        public virtual CardsCollection? CardsCollection { get; set; }
    }
}
