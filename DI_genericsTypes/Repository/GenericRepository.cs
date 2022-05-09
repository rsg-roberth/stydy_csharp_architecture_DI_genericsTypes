using DI_genericsTypes.Model;

namespace DI_genericsTypes.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public void ADD(T model)
        {
            //Todo
        }
    }
}
