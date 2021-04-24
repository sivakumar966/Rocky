using Rocky_Models;

namespace Rocky_DataAccess.Repository.IRepoditory
{
    public interface IApplicationTypeRepository : IRepository<ApplicationType>
    {
        void Update(ApplicationType obj);

    }
}
