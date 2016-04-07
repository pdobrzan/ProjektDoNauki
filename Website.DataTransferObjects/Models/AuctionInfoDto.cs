using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website.DataTransferObjects.Models
{
    public class AuctionInfoDto
    {
        public int AuctionNumber { get; set; }
        public int Price { get; set; }
        public int Power { get; set; }
    }
}
