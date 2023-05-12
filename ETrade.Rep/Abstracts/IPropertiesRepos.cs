﻿using ETrade.Core;
using ETrade.DTO;
using ETrade.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Abstracts
{
    public interface IPropertiesRepos:IBaseRepository<Properties>
    {
       public List<PropertiesDTO> GetProperties();
    }
}
