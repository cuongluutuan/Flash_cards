using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UnitOfWork
    {
        private MyApplicationDBContext context = new MyApplicationDBContext();
        private BaseReposity<CardsCollection> cardsCollectionRepository;
        private BaseReposity<CardEntry> cardEntryRepository;

        public BaseReposity<CardsCollection> CardsCollectionRepository 
        {
            get
            { 
                if (cardsCollectionRepository == null)
                {
                    cardsCollectionRepository = new BaseReposity<CardsCollection>(context);
                }
                return cardsCollectionRepository;
            }
        }

        public BaseReposity<CardEntry> BaseReposity
        {
            get
            {
                if (cardEntryRepository == null)
                {
                    cardEntryRepository = new BaseReposity<CardEntry>(context);
                }
                return cardEntryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
