using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Models
{
    public interface IPartRepository
    {
        void Add(ParticipantModel partModel);
        void Edit(ParticipantModel partModel);
        void Delete(int id);
        IEnumerable<ParticipantModel> GetAll();
        IEnumerable<ParticipantModel> GetByValue(string value);
    }
}
