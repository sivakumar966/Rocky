using Rocky_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocky_DataAccess.Repository.IRepoditory
{
   public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);

    }
}
