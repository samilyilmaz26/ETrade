using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace ETrade.Rep.Concretes
{
    public class OrdersRepos : BaseRepository<Orders>, IOrdersRepos
    {
       
        public OrdersRepos(Context context) : base(context)
        {
            
        }

        public List<Orders> GetOrders(Guid Id)
        {
           return  List().Where(x=> x.UserId == Id &&  x.isDelivered == false ).ToList();   
        
        }
    }
}
