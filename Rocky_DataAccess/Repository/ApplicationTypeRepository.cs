using Rocky_DataAccess.Repository.IRepoditory;
using Rocky_Models;

namespace Rocky_DataAccess.Repository
{
    public class ApplicationTypeRepository : Repository<ApplicationType>, IApplicationTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypeRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(ApplicationType obj)
        {
            var objFromDb = base.FirstOrDefault(x => x.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = obj.Name;                
            }
        }
    }
}
