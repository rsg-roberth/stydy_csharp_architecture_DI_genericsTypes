using DI_genericsTypes.Model;

namespace DI_genericsTypes.Repository
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        void ADD(T model);
    }
}
