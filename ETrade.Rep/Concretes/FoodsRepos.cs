using ETrade.Core;
using ETrade.Dal;
using ETrade.DTO;
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
    public class FoodsRepos : BaseRepository<Foods>, IFoodsRepos
    {
       
        public FoodsRepos(Context context) : base(context)
        {
            
        }

        public List<FoodDTO> GetFoods()
        {
           return Set().Select(x=> new FoodDTO { Id= x.FoodId, Name= x.FoodName}).ToList();
        }
    }
}
