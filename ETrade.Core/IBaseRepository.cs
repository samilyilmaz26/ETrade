using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Core
{
	public interface IBaseRepository<T> where T : class
	{
		public List<T> List();
		public T Find(Guid Id);
		public bool Update(T entity);
		public bool Delete(T entity);
		public bool Add(T entity);
		DbSet<T> Set();
	}
}
