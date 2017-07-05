using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libretto.Model.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public virtual User Buyer { get; set; }
        public virtual User Seller { get; set; }
        public virtual Auction Auction { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }



        public Order Self {
            get
            {
                return this;
            }
        }


    }
}
