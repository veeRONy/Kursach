using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач._Repository;
using Курсач.Models;
using Курсач.Presenters;
using Курсач.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Курсач
{
    public class Events: _Validator
    {

        MainForm form;
        public Events(MainForm form)
        {
            this.form = form;
            form.AddConfEvent += AddConf;
            form.AddOrgEvent += AddOrg;
            form.AddPartEvent += AddPart;

            form.CancelConfEvent += CancelConf;
            form.CancelOrgEvent += CancelOrg;
            form.CancelPartEvent += CancelPart;
            form.CancelRegEvent += CancelReg;

            form.EditConfEvent += EditConf;
            form.EditOrgEvent += EditOrg;
            form.EditPartEvent += EditPart;

            form.DeleteConfEvent += DeleteConf;
            form.DeletePartEvent += DeletePart;
            form.DeleteOrgEvent += DeleteOrg;
            form.DeleteRegEvent += DeleteReg;

            form.SaveConfEvent += SaveConf;
            form.SavePartEvent += SavePart;
            form.SaveOrgEvent += SaveOrg;
            form.SaveRegEvent += SaveReg;

            form.SearchConfEvent += SearchConf;
            form.SearchPartEvent += SearchPart;
            form.SearchOrgEvent += SearchOrg;

            form.RegEvent += Reg;

        }

        private void Reg(object sender, EventArgs e)
        {
            var participant = (ParticipantModel)form.partsbindingSource.Current;
            form.CONF_ID = "";
            form.TOPIC = "";
            form.PART_ID = participant.Participant_id;
        }

        private void SearchOrg(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(form.SearchValueOrg);
            if (emptyValue == false)
            {
                form.orgList = form.repository.GetByValueOrgs(form.SearchValueOrg);
            }
            else
                form.orgList = form.repository.GetAllOrgs();
            form.orgsbindingSource.DataSource = form.orgList;
        }

        private void SearchPart(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(form.SearchValuePart);
            if (emptyValue == false)
            {
                form.partList = form.repository.GetByValueParts(form.SearchValuePart);
            }
            else
                form.partList = form.repository.GetAllParts();
            form.partsbindingSource.DataSource = form.partList;
        }

        private void SearchConf(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(form.SearchValueConf);
            if (emptyValue == false)
            {
                form.confList = form.repository.GetByValueConfs(form.SearchValueConf);
            }
            else
                form.confList = form.repository.GetAllConfs();
            form.confsbindingSource.DataSource = form.confList;
        }

        private void SaveReg(object sender, EventArgs e)
        {
            var model = new Conf_Part_Model();
            model.Part_id = form.PART_ID;
            model.Conf_id = form.CONF_ID;
            model.Topic = form.TOPIC;

            try
            {
                Validate(model);
                form.repository.AddReg(model);
                form.Message = "Участник успешно зарегистрирован.";
                form.IsSuccess = true;
                form.LoadAllConfPartList();
                form.LoadAllConfList();
            }
            catch (Exception ex)
            {
                form.IsSuccess = false;
                form.Message = ex.Message;
            }
        }

        private void SaveOrg(object sender, EventArgs e)
        {
            var model = new OrgModel();
            model.Org_id = form.org_id;
            model.Org_surname = form.org_surname;
            model.Org_name = form.org_name;
            model.Org_company = form.org_company;
            model.Org_email = form.org_email;

            try
            {
                Validate(model);
                if (form.IsEdit)
                {
                    form.repository.EditOrg(model);
                    form.Message = "Данные организатора успешно изменены.";
                }
                else
                {
                    form.repository.AddOrg(model);
                    form.Message = "Организатор успешно добавлен.";
                }
                form.IsSuccess = true;
                form.LoadAllOrgList();
            }
            catch (Exception ex)
            {
                form.IsSuccess = false;
                form.Message = ex.Message;
            }
        }

        private void SavePart(object sender, EventArgs e)
        {
            var model = new ParticipantModel();
            model.Participant_id = form.part_id;
            model.Participant_surname = form.part_surname;
            model.Participant_name = form.part_name;
            model.Participant_email = form.part_email;

            try
            {
                Validate(model);
                if (form.IsEdit)
                {
                    form.repository.EditPart(model);
                    form.Message = "Данные участника успешно изменены.";
                }
                else
                {
                    form.repository.AddPart(model);
                    form.Message = "Участник успешно добавлен.";
                }
                form.IsSuccess = true;
                form.LoadAllPartList();
            }
            catch (Exception ex)
            {
                form.IsSuccess = false;
                form.Message = ex.Message;
            }
        }

        private void SaveConf(object sender, EventArgs e)
        {
            var model = new ConfModel();
            model.Conf_id = form.conf_id;
            model.Conf_topic = form.conf_topic;
            model.Conf_organizer_id = form.conf_organizer_id;
            model.Conf_date = form.conf_date;
            model.Conf_time = form.conf_time;
            model.Conf_address = form.conf_address;
            model.Max_num_of_participants = form.max_num_of_participants;

            try
            {
                Validate(model);
                if (form.IsEdit)
                {
                    form.repository.EditConf(model);
                    form.Message = "Конференция успешно изменена.";
                }
                else
                {
                    form.repository.AddConf(model);
                    form.Message = "Конференция успешно добавлена.";
                }
                form.IsSuccess = true;
                form.LoadAllConfList();
                return;
            }
            catch (Exception ex)
            {
                form.IsSuccess = false;
                form.Message = ex.Message;
            }
            return;
        }

        private void DeleteReg(object sender, EventArgs e)
        {
            try
            {
                var model = (Conf_Part_Model)form.confpartbindingsource.Current;
                form.repository.DeleteReg(model.Part_id, Convert.ToInt32(model.Conf_id), model.Topic);
                form.IsSuccess = true;
                form.Message = "Регистрация участника успешно отменена.";
                form.LoadAllConfPartList();
                form.LoadAllConfList();
            }
            catch
            {
                form.IsSuccess = false;
                form.Message = "Ошибка! Регистрация участника не была отменена.";
            }
        }

        private void DeleteOrg(object sender, EventArgs e)
        {
            try
            {
                var org = (OrgModel)form.orgsbindingSource.Current;
                form.repository.DeleteOrg(org.Org_id);
                form.IsSuccess = true;
                form.Message = "Данные организатора успешно удалены.";
                form.LoadAllOrgList();
                form.LoadAllConfList();
                form.LoadAllConfPartList();
            }
            catch
            {
                form.IsSuccess = false;
                form.Message = "Ошибка! Данные организатора не были удалены.";
            }
        }

        private void DeletePart(object sender, EventArgs e)
        {
            try
            {
                var participant = (ParticipantModel)form.partsbindingSource.Current;
                form.repository.DeletePart(participant.Participant_id);
                form.IsSuccess = true;
                form.Message = "Данные участника успешно удалены.";
                form.LoadAllPartList();
                form.LoadAllConfPartList();
                form.LoadAllConfList();
                return;
            }
            catch
            {
                form.IsSuccess = false;
                form.Message = "Ошибка! Участник не был удален.";
            }
            return;
        }

        private void DeleteConf(object sender, EventArgs e)
        {
            try
            {
                var conf = (ConfModel)form.confsbindingSource.Current;

                form.repository.DeleteConf(conf.Conf_id);

                form.IsSuccess = true;
                form.Message = "Конференция успешно удалена.";
                form.LoadAllConfList();
                form.LoadAllConfPartList();
                return;
            }
            catch
            {
                form.IsSuccess = false;
                form.Message = "Ошибка! Конференция не была удалена.";
            }
            return;
        }

        private void EditPart(object sender, EventArgs e)
        {
            var participant = (ParticipantModel)form.partsbindingSource.Current;
            form.part_id = participant.Participant_id;
            form.part_surname = participant.Participant_surname;
            form.part_name = participant.Participant_name;
            form.part_email = participant.Participant_email;
            form.IsEdit = true;
        }

        private void EditOrg(object sender, EventArgs e)
        {
            var org = (OrgModel)form.orgsbindingSource.Current;
            form.org_id = org.Org_id;
            form.org_surname = org.Org_surname;
            form.org_name = org.Org_name;
            form.org_company = org.Org_company;
            form.org_email = org.Org_email;
            form.IsEdit = true;
        }

        private void EditConf(object sender, EventArgs e)
        {
            var conf = (ConfModel)form.confsbindingSource.Current;
            form.conf_id = conf.Conf_id;
            form.conf_topic = conf.Conf_topic;
            form.conf_organizer_id = conf.Conf_organizer_id;
            form.conf_date = conf.Conf_date;
            form.conf_time = conf.Conf_time;
            form.conf_address = conf.Conf_address;
            form.max_num_of_participants = conf.Max_num_of_participants;
            form.IsEdit = true;
        }

        private void CancelReg(object sender, EventArgs e)
        {
            form.CONF_ID = "";
            form.TOPIC = "";
            form.PART_ID = 0;
        }

        private void CancelPart(object sender, EventArgs e)
        {
            form.part_id = 0;
            form.part_surname = "";
            form.part_name = "";
            form.part_email = "";
        }

        private void CancelOrg(object sender, EventArgs e)
        {
            form.org_id = 0;
            form.org_surname = "";
            form.org_name = "";
            form.org_company = "";
            form.org_email = "";
        }

        private void CancelConf(object sender, EventArgs e)
        {
            form.conf_id = 0;
            form.conf_topic = "";
            form.conf_organizer_id = "";
            form.conf_date = "";
            form.conf_time = "";
            form.conf_address = "";
            form.max_num_of_participants = 0;
        }

        private void AddPart(object sender, EventArgs e)
        {
            form.IsEdit = false;
            CancelPart(sender, e);
        }

        private void AddOrg(object sender, EventArgs e)
        {
            form.IsEdit = false;
            CancelOrg(sender, e);
        }

        private void AddConf(object sender, EventArgs e)
        {
            form.IsEdit = false;
            CancelConf(sender, e);
        }

        
    }
}
