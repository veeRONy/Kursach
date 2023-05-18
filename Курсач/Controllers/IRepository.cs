using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Models
{
    public interface IRepository
    {
        void AddConf(ConfModel confModel);
        void EditConf(ConfModel confModel);
        void DeleteConf(int id);
        IEnumerable<ConfModel> GetAllConfs();
        IEnumerable<OrgModel> GetAllOrganizers();
        IEnumerable<ConfModel> GetAllConfsForCB();
        IEnumerable<ConfModel> GetByValueConfs(string value);

        void AddOrg(OrgModel orgModel);
        void EditOrg(OrgModel orgModel);
        void DeleteOrg(int id);
        IEnumerable<OrgModel> GetAllOrgs();
        IEnumerable<OrgModel> GetByValueOrgs(string value);


        void AddPart(ParticipantModel partModel);
        void EditPart(ParticipantModel partModel);
        void DeletePart(int id);
        void AddReg(ConfPartModel confpartModel);
        void DeleteReg(int part_id, int conf_id, string topic);
        IEnumerable<ConfPartModel> GetAllConfPart();
        IEnumerable<ParticipantModel> GetAllParts();
        IEnumerable<ParticipantModel> GetByValueParts(string value);
    }
}
