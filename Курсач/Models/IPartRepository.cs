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
        void AddReg(Conf_Part_Model confpartModel);
        void DeleteReg(int part_id, int conf_id, string topic);
        IEnumerable<Conf_Part_Model> GetAllConfPart();
        IEnumerable<ParticipantModel> GetAll();
        IEnumerable<ParticipantModel> GetByValue(string value);
    }
}
