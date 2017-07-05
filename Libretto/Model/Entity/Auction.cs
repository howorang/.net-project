using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libretto.Model.Entity
{
    public class Auction
    {
        public int AuctionId { get; set; }
        public string Title { get; set; }
        public virtual User Creator { get; set; }
        public int ItemQuantity { get; set; }
        public virtual byte[] Image { get; set; }
        public decimal PricePerUnit { get; set; }
        public string Description { get; set; }



        public Auction Self {
            get
            {
                return this;
            }
        }



        public override string ToString()
        {
            return Title;
        }
    }

}
