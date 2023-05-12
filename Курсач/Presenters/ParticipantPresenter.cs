using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач._Repository;
using Курсач.Models;
using Курсач.Views;
using Курсач.Presenters;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Курсач.Presenters
{
    public class ParticipantPresenter
    {
        private IPartView partView;
        private IPartRepository partRepository;
        private BindingSource partsbindingSource;
        private BindingSource confpartbindingsource;
        private IEnumerable<ParticipantModel> partList;
        private IEnumerable<Conf_Part_Model> confpartList;

        public ParticipantPresenter(IPartView partView, IPartRepository partRepository)
        {
            this.partView = partView;
            this.partRepository = partRepository;
            this.partsbindingSource = new BindingSource();
            this.confpartbindingsource = new BindingSource();


            this.partView.SearchEvent += SearchPart;
            this.partView.AddEvent += AddPart;
            this.partView.EditEvent += LoadSelectedPartToEdit;
            this.partView.DeleteEvent += DeleteSelectedPart;
            this.partView.SaveEvent += SavePart;
            this.partView.CancelEvent += CancelAction;
            this.partView.AddPartInConfEvent += AddPartInConf;
            this.partView.DeleteRegEvent += DeleteReg;
            this.partView.SaveRegEvent += SaveReg;
            this.partView.CancelRegEvent += CancelReg;

            this.partView.SetPartListBindingSource(partsbindingSource, confpartbindingsource);
            LoadAllPartList();
            LoadAllConfPartList();
            this.partView.Show();

        }

        private void AddPartInConf(object sender, EventArgs e)
        {
            var participant = (ParticipantModel)partsbindingSource.Current;
            partView.CONF_ID = "";
            partView.TOPIC = "";
            partView.PART_ID = participant.Participant_id;
        }

        private void CancelReg(object sender, EventArgs e)
        {
            partView.CONF_ID = "";
            partView.TOPIC = "";
            partView.PART_ID = 0;
        }

        private void SaveReg(object sender, EventArgs e)
        {
            var model = new Conf_Part_Model();
            model.Part_id = partView.PART_ID;
            model.Conf_id = partView.CONF_ID;
            model.Topic = partView.TOPIC;

            try
            {
                Validate(model);
                partRepository.AddReg(model);
                partView.Message = "Участник успешно зарегистрирован.";
                partView.IsSuccess = true;
                LoadAllConfPartList();
            }
            catch(Exception ex)
            {
                partView.IsSuccess = false;
                partView.Message = ex.Message;
            }
        }

        private void LoadAllConfPartList()
        {
            confpartList = partRepository.GetAllConfPart();
            confpartbindingsource.DataSource = confpartList;
        }

        private void DeleteReg(object sender, EventArgs e)
        {
            try
            {
                var model = (Conf_Part_Model)confpartbindingsource.Current;
                partRepository.DeleteReg(model.Part_id, Convert.ToInt32(model.Conf_id), model.Topic);
                partView.IsSuccess = true;
                partView.Message = "Регистрация участника успешно отменена.";
                LoadAllConfPartList();
            }
            catch (Exception ex)
            {
                partView.IsSuccess = false;
                partView.Message = "Ошибка! Регистрация участника не была отменена.";
            }

        }


        private void LoadAllPartList()
        {
            partList = partRepository.GetAll();
            partsbindingSource.DataSource = partList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            partView.part_id = 0;
            partView.part_surname = "";
            partView.part_name = "";
            partView.part_email = "";
        }

        private void SavePart(object sender, EventArgs e)
        {
            var model = new ParticipantModel();
            model.Participant_id = partView.part_id;
            model.Participant_surname = partView.part_surname;
            model.Participant_name = partView.part_name;
            model.Participant_email = partView.part_email;


            try
            {
                Validate(model);
                if (partView.IsEdit)
                {
                    partRepository.Edit(model);
                    partView.Message = "Данные участника успешно изменены.";
                }
                else
                {
                    partRepository.Add(model);
                    partView.Message = "Участник успешно добавлен.";
                }
                partView.IsSuccess = true;
                LoadAllPartList();
            }
            catch (Exception ex)
            {
                partView.IsSuccess = false;
                partView.Message = ex.Message;
            }
        }

        private void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (isValid == false)
            {
                foreach (var item in results)
                    errorMessage += "- " + item.ErrorMessage + "\n";
                throw new Exception(errorMessage);
            }
        }

        

        private void DeleteSelectedPart(object sender, EventArgs e)
        {
            try
            {
                var participant = (ParticipantModel)partsbindingSource.Current;
                partRepository.Delete(participant.Participant_id);
                partView.IsSuccess = true;
                partView.Message = "Данные участника успешно удалены.";
                LoadAllPartList();
            }
            catch (Exception ex)
            {
                partView.IsSuccess = false;
                partView.Message = "Ошибка! Участник не был удален.";
            }
        }

        private void LoadSelectedPartToEdit(object sender, EventArgs e)
        {
            var participant = (ParticipantModel)partsbindingSource.Current;
            partView.part_id = participant.Participant_id;
            partView.part_surname = participant.Participant_surname;
            partView.part_name = participant.Participant_name;
            partView.part_email = participant.Participant_email;
            partView.IsEdit = true;
        }

        private void AddPart(object sender, EventArgs e)
        {
            CleanViewFields();
            partView.IsEdit = false;
        }

        private void SearchPart(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.partView.SearchValue);
            if (emptyValue == false)
            {
                partList = partRepository.GetByValue(this.partView.SearchValue);
            }
            else
                partList = partRepository.GetAll();
            partsbindingSource.DataSource = partList;
        }
    }
}
