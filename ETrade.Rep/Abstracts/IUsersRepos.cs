using ETrade.Core;
using ETrade.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Abstracts
{
	public interface IUsersRepos : IBaseRepository<Users>
	{
		public Users Login(Users user);
		public void Logout();
		public bool Register(Users user);
	}
}
