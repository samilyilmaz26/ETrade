using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
    public class OrderDetails:Base

    {
        
        public Guid OrderId { get; set; }
        public Guid FoodId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        [ForeignKey("OrderId")]
        public Orders Orders { get; set; }
        [ForeignKey("FoodId")]
        public  Foods Foods { get; set; }
    }
}