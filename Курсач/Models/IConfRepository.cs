using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Models
{
    public interface IConfRepository
    {
        void Add(ConfModel confModel);
        void Edit(ConfModel confModel);
        void Delete(int id);
        IEnumerable<ConfModel> GetAll();
        IEnumerable<OrgModel> GetAllOrganizers();
        IEnumerable<ConfModel> GetAllConfs();
        IEnumerable<ConfModel> GetByValue(string value);
    }
}
