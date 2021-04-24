using Rocky_DataAccess.Repository.IRepoditory;
using Rocky_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocky_DataAccess.Repository
{
   public class InquiryDetailRepository : Repository<InquiryDetail> , IInquiryDetailRepository
    {
        private readonly ApplicationDbContext _db;

        public InquiryDetailRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(InquiryDetail Obj)
        {
            _db.Update(Obj);
        }
    }
}
