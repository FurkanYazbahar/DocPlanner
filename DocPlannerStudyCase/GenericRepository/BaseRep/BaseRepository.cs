using DocPlannerStudyCase.GenericRepository.InterfaceRep;
using DocPlannerStudyCase.Models.Context;
using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Models.Enums;
using System.Linq.Expressions;

namespace DocPlannerStudyCase.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;

        protected BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Add(T item)
        {
            item.Status = DataStatus.Inserted;
            item.CreatedDate = DateTime.Now;
            _dbContext.Set<T>().Add(item);            
            Save();
        }

        public void AddRange(List<T> list)
        {
            _dbContext.Set<T>().AddRange(list);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _dbContext.Set<T>().Any(exp);            
        }

        public void Delete(T item)
        {
            T unchangedEtity = Find(item.Id);

            item.Status = DataStatus.Deleted;
            item.ModifiedDate = DateTime.Now;
            item.DeletedDate = DateTime.Now;

            _dbContext.Entry(unchangedEtity).CurrentValues.SetValues(item);
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (T item in list)
            {
                Delete(item);
            }
        }

        public void Destroy(T item)
        {
            _dbContext.Set<T>().Remove(item);
            Save();
        }

        public void DestroyRange(List<T> list)
        {
            _dbContext.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _dbContext.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public List<T> GetDeleteds()
        {
            return Where(x => x.Status == DataStatus.Deleted);
        }

        public List<T> GetModifieds()
        {
           return Where(x => x.Status == DataStatus.Updated);
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _dbContext.Set<T>().Select(exp);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _dbContext.Set<T>().Where(x => x.Status != DataStatus.Deleted).Select(exp);
        }

        public void Update(T item)
        {
            T unchangedEtity = Find(item.Id);

            item.Status = DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            
            _dbContext.Entry(unchangedEtity).CurrentValues.SetValues(item);
            Save();
        }

        public void UpdateRange(List<T> list)
        {
            foreach (T item in list)
            {
                Update(item);
            }
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _dbContext.Set<T>().Where(exp).ToList();
        }
    }
}
