using ETrade.Dal;
using ETrade.Rep.Abstracts;
using ETrade.Rep.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UOW
{
    public class Uow : IUow
    {
        private readonly Context context;

        public Uow(Context context, IFoodsRepos foodsRepos, IOrdersRepos ordersRepos, IOrderDetailsRepos orderDetailsRepos, IUsersRepos usersRepos, IPropertiesRepos propertiesRepos, ICategoriesRepos categoriesRepos)
        {
            this.context = context;
            this.foodsRepos = foodsRepos;
            this.ordersRepos = ordersRepos;
            this.orderDetailsRepos = orderDetailsRepos;
            this.usersRepos = usersRepos;
            this.propertiesRepos = propertiesRepos;
            this.categoriesRepos = categoriesRepos;
        }
        public IFoodsRepos foodsRepos { get; }

        public IOrdersRepos ordersRepos { get; }

        public IUsersRepos usersRepos { get; }

        public IPropertiesRepos propertiesRepos { get; }

        public IOrderDetailsRepos orderDetailsRepos { get; }
        public ICategoriesRepos categoriesRepos { get; }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
