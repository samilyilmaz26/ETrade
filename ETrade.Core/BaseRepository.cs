using ETrade.Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Core
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		private readonly Context context;

		public BaseRepository(Context context)
		{
			this.context = context;
		}
		public IQueryable<T> Qry()
		{
		   return  List().AsQueryable();	
		}

		public bool Add(T entity)
		{
			try
			{
				Set().Add(entity);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}

		public bool Delete(T entity)
		{
			try
			{
				Set().Remove(entity);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}

		public T Find(int id)
		{
			return Set().Find(id);
		}

		public T Find(Guid Id)
		{
			return Set().Find(Id);
		}

		public List<T> List()
		{
			return Set().ToList();
		}

		public DbSet<T> Set()
		{
			return context.Set<T>();
		}

		public bool Update(T entity)
		{
			try
			{
				Set().Update(entity);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}
	}
}
