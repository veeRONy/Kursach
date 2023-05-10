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

namespace Курсач.Presenters
{
    public class ParticipantPresenter
    {
        private IPartView partView;
        private IPartRepository partRepository;
        private BindingSource partsbindingSource;
        private IEnumerable<ParticipantModel> partList;

        public ParticipantPresenter(IPartView partView, IPartRepository partRepository)
        {
            this.partView = partView;
            this.partRepository = partRepository;
            this.partsbindingSource = new BindingSource();


            this.partView.SearchEvent += SearchPart;
            this.partView.AddEvent += AddPart;
            this.partView.EditEvent += LoadSelectedPartToEdit;
            this.partView.DeleteEvent += DeleteSelectedPart;
            this.partView.SaveEvent += SavePart;
            this.partView.CancelEvent += CancelAction;

            this.partView.SetPartListBindingSource(partsbindingSource);
            LoadAllPartList();
            this.partView.Show();
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
            partView.part_topic = "";
            partView.part_email = "";
            partView.conf_ID = 0;
        }

        private void SavePart(object sender, EventArgs e)
        {
            var model = new ParticipantModel();
            model.Participant_id = partView.part_id;
            model.Participant_surname = partView.part_surname;
            model.Participant_name = partView.part_name;
            model.Topic = partView.part_topic;
            model.Participant_email = partView.part_email;
            model.Conf_id = partView.conf_ID;


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

        private void Validate(ParticipantModel model)
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
            partView.part_topic = participant.Topic;
            partView.part_email = participant.Participant_email;
            partView.conf_ID = participant.Conf_id;
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
