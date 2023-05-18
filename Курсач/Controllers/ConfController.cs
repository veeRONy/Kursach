using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Models;
using Курсач.Views;

namespace Курсач.Presenters
{
    public class ConfController: _Validator
    {
        MainForm form;
        

        public ConfController(MainForm form)
        {
            this.form = form;
            form.AddConfEvent += AddConf;
            form.CancelConfEvent += CancelConf;
            form.EditConfEvent += EditConf;
            form.DeleteConfEvent += DeleteConf;
            form.SaveConfEvent += SaveConf;
            form.SearchConfEvent += SearchConf;
            

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

        private void AddConf(object sender, EventArgs e)
        {
            form.IsEdit = false;
            CancelConf(sender, e);
        }
    }
}
