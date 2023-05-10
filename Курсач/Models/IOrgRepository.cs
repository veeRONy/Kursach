using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Models
{
    public interface IOrgRepository
    {
        void Add(OrgModel orgModel);
        void Edit(OrgModel orgModel);
        void Delete(int id);
        IEnumerable<OrgModel> GetAll();
        IEnumerable<OrgModel> GetByValue(string value);
    }
}
