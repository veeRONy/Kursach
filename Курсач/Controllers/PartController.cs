using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Models;
using Курсач.Views;

namespace Курсач.Presenters
{
    public class PartController: _Validator
    {
        MainForm form;

        public PartController(MainForm form)
        {
            this.form = form;
            form.AddPartEvent += AddPart;
            form.CancelPartEvent += CancelPart;
            form.CancelRegEvent += CancelReg;
            form.EditPartEvent += EditPart;
            form.DeletePartEvent += DeletePart;
            form.DeleteRegEvent += DeleteReg;
            form.SavePartEvent += SavePart;
            form.SaveRegEvent += SaveReg;
            form.SearchPartEvent += SearchPart;
            form.RegEvent += Reg;
        }

        private void Reg(object sender, EventArgs e)
        {
            var participant = (ParticipantModel)form.partsbindingSource.Current;
            form.CONF_ID = "";
            form.TOPIC = "";
            form.PART_ID = participant.Participant_id;
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

        private void SaveReg(object sender, EventArgs e)
        {
            var model = new ConfPartModel();
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

        private void DeleteReg(object sender, EventArgs e)
        {
            try
            {
                var model = (ConfPartModel)form.confpartbindingsource.Current;
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

        private void EditPart(object sender, EventArgs e)
        {
            var participant = (ParticipantModel)form.partsbindingSource.Current;
            form.part_id = participant.Participant_id;
            form.part_surname = participant.Participant_surname;
            form.part_name = participant.Participant_name;
            form.part_email = participant.Participant_email;
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

        private void AddPart(object sender, EventArgs e)
        {
            form.IsEdit = false;
            CancelPart(sender, e);
        }
    }
}
