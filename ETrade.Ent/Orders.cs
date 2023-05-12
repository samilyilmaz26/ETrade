using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
	public class Orders : Base
    {
        [Key]
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
		public decimal TotalPrice { get; set; }
	 
		public string  ShippingAddress { get; set; }
		public bool isDelivered { get; set; }
		[ForeignKey(nameof(UserId))]
		public Users Users{ get; set; }
		public ICollection<OrderDetails> OrderDetails { get; set; }
	}
}
