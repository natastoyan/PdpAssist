namespace PdpAssist.Server.Repositories
{
	public interface IRepository<T>
	{
		void Add(T entity);
		void Remove(T entity);
		IEnumerable<T> GetAll();
	}
}
