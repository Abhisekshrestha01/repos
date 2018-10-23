using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Logic
{
    public class dutchBid
    {
        internal string custname;

        public string itemname { get; set; }
        public int itemid { get; set; }
        public int custid { get; set; }
        public double amount { get; set; }
        public int bidQty { get; set; }
        public int avaliableQty { get; set; }
        public DateTime bidFinishDate { get; set; }
    

}
}