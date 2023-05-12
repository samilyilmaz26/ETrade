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
    public class PropertiesRepos : BaseRepository<Properties>, IPropertiesRepos
    {
       
        public PropertiesRepos(Context context) : base(context)
        {
            
        }

        public List<PropertiesDTO> GetProperties()
        {
            return Set().Select(x=> new PropertiesDTO { Id =x.PropertyId, Name= x.PropertyName}).ToList();
        }
    }
}
