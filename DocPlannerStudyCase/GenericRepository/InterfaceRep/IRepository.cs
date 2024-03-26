using DocPlannerStudyCase.Models.Entities;
using System.Linq.Expressions;

namespace DocPlannerStudyCase.GenericRepository.InterfaceRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //List Commands
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetModifieds();
        List<T> GetDeleteds();

        //Modify Commands
        void Add(T item);
        void AddRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //Linq Commands
        //Like This  _db.Doctor.Where(x=>x.Gender.Contains("Male")).ToList();
        List<T> Where(Expression<Func<T,bool>> exp);
        bool Any(Expression<Func<T,bool>> exp);
        T FirstOrDefault(Expression<Func<T,bool>> exp);
        object Select(Expression<Func<T,object>> exp);
        IQueryable<X> Select<X>(Expression<Func<T,X>> exp);

        //Find Command
        T Find(int id);
    }
}
