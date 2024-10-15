using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryCard
    {
        public int CardNumber { get; set; }
        private static int NumberOfCards = 0;

        public LibraryCard()
        {
            NumberOfCards++;
        }

        public int getCardsNumber()
        {
            return NumberOfCards;
        }
    }
}
