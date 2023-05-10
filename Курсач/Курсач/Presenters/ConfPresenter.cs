using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач.Views;
using Курсач.Models;
using System.ComponentModel.DataAnnotations;

namespace Курсач.Presenters
{
    public class ConfPresenter
    {
        private IConfView confView;
        private IConfRepository confRepository;
        private BindingSource confsbindingSource;
        private IEnumerable<ConfModel> confList;

        public ConfPresenter(IConfView confView, IConfRepository confRepository)
        {
            this.confsbindingSource = new BindingSource();
            this.confView = confView;
            this.confRepository = confRepository;
            this.confView.SearchEvent += SearchConf;
            this.confView.AddEvent += AddConf;
            this.confView.EditEvent += LoadSelectedConfToEdit;
            this.confView.DeleteEvent += DeleteSelectedConf;
            this.confView.SaveEvent += SaveConf;
            this.confView.CancelEvent += CancelAction;



            this.confView.SetConfsListBindingSource(confsbindingSource);
            LoadAllConfList();
            this.confView.Show();
        }

        private void LoadAllConfList()
        {
            confList = confRepository.GetAll();
            confsbindingSource.DataSource = confList;
        }

        public void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> results= new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (isValid == false)
            {
                foreach (var item in results)
                    errorMessage += "- " + item.ErrorMessage + "\n";
                throw new Exception(errorMessage);
            }
        }

        private void CleanViewFields()
        {
            confView.conf_id = 0;
            confView.conf_topic = "";
            confView.conf_organizer_id = 0;
            confView.conf_date = "";
            confView.conf_time = "";
            confView.conf_address = "";
            confView.max_num_of_participants = 0;
        }

        private void SearchConf(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.confView.SearchValue);
            if (emptyValue == false)
            {
                confList = confRepository.GetByValue(this.confView.SearchValue);
            }
            else
                confList = confRepository.GetAll();
            confsbindingSource.DataSource = confList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveConf(object sender, EventArgs e)
        {
            var model = new ConfModel();
            model.Conf_id = confView.conf_id;
            model.Conf_topic = confView.conf_topic;
            model.Conf_organizer_id = confView.conf_organizer_id;
            model.Conf_date = confView.conf_date;
            model.Conf_time = confView.conf_time;
            model.Conf_address = confView.conf_address;
            model.Max_num_of_participants = confView.max_num_of_participants;
           
            try
            {
                Validate(model);
                if (confView.IsEdit)
                {
                    confRepository.Edit(model);
                    confView.Message = "Конференция успешно изменена.";
                }
                else
                {
                    confRepository.Add(model);
                    confView.Message = "Конференция успешно добавлена.";
                }
                confView.IsSuccess=true;
                LoadAllConfList();
            }
            catch (Exception ex)
            {
                confView.IsSuccess = false;
                confView.Message = ex.Message;
            }
        }

        private void DeleteSelectedConf(object sender, EventArgs e)
        {
            try
            {
                var conf = (ConfModel)confsbindingSource.Current;
                confRepository.Delete(conf.Conf_id);
                confView.IsSuccess = true;
                confView.Message = "Конференция успешно удалена.";
                LoadAllConfList();
            }
            catch (Exception ex)
            {
                confView.IsSuccess = false;
                confView.Message = "Ошибка! Конференция не была удалена.";
            }
        }

        private void LoadSelectedConfToEdit(object sender, EventArgs e)
        {
            var conf = (ConfModel)confsbindingSource.Current;
            confView.conf_id = conf.Conf_id;
            confView.conf_topic = conf.Conf_topic;
            confView.conf_organizer_id = conf.Conf_organizer_id;
            confView.conf_date = conf.Conf_date;
            confView.conf_time = conf.Conf_time;
            confView.conf_address = conf.Conf_address;
            confView.max_num_of_participants = conf.Max_num_of_participants;
            confView.IsEdit = true;
        }

        private void AddConf(object sender, EventArgs e)
        {
            CleanViewFields();
            confView.IsEdit = false;

        }


    }
}
