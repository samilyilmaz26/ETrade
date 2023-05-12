using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
	public class Foods : Base
	{
        [Key]
        public Guid FoodId { get; set; }
        public string FoodName { get; set; }
         
        public Guid CategoryId { get; set; }
        
        public string Description { get; set; }
        public string Img { get; set; }
        public ICollection <Properties> Properties { get; set; }
        [ForeignKey("CategoryId")]
        public  Categories Categories {get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
  
    }
}
