using ETrade.Core;
using ETrade.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Abstracts
{
	public interface IOrdersRepos : IBaseRepository<Orders>
	{
		List<Orders> GetOrders(Guid Id);
	}
}
