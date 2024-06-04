using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Service
{
	public interface IGenericService<T> where T : class
	{
		Task<int> Insert(T entity);
		Task<int> Update(T entity);
		Task<int> Delete(T entity);
		Task<List<T>> GetAll();
		Task<T> GetById(int id);
	}
}
