using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UOW
{
	public interface IUow
	{
		public IFoodsRepos foodsRepos { get; }
		public IOrdersRepos ordersRepos{ get; }
        public IUsersRepos  usersRepos { get; }
        public IPropertiesRepos propertiesRepos{ get; }
        public IOrderDetailsRepos orderDetailsRepos   { get; }
        public ICategoriesRepos categoriesRepos{ get; }
        public void Commit();





    }
}
