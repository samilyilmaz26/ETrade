using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
	public class Users : Base
	{
        [Key]
        public Guid UserId{ get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public string  ShipAddress { get; set; }
        public ICollection<Orders> Orders { get; set; }

    }
}
