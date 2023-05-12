using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
	public class Categories : Base
	{
        [Key]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Foods>  Foods{ get; set; }
    }
}
