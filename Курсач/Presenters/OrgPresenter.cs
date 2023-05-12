using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач._Repository;
using Курсач.Models;
using Курсач.Views;

namespace Курсач.Presenters
{
    public class OrgPresenter
    {
        private IOrgView orgView;
        private IOrgRepository orgRepository;
        private BindingSource orgsbindingSource;
        private IEnumerable<OrgModel> orgList;

        public OrgPresenter(IOrgView orgView, IOrgRepository orgRepository)
        {
            this.orgView = orgView;
            this.orgRepository = orgRepository;
            this.orgsbindingSource = new BindingSource();

            this.orgView.SearchEvent += SearchOrg;
            this.orgView.AddEvent += AddOrg;
            this.orgView.EditEvent += LoadSelectedOrgToEdit;
            this.orgView.DeleteEvent += DeleteSelectedOrg;
            this.orgView.SaveEvent += SaveOrg;
            this.orgView.CancelEvent += CancelAction;

            orgView.IsEdit = false;

            this.orgView.SetOrgsListBindingSource(orgsbindingSource);
            LoadAllOrgList();
            this.orgView.Show();
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            orgView.org_id = 0;
            orgView.org_surname = "";
            orgView.org_name = "";
            orgView.org_company = "";
            orgView.org_email = "";
        }

        private void SaveOrg(object sender, EventArgs e)
        {
            var model = new OrgModel();
            model.Org_id = orgView.org_id;
            model.Org_surname = orgView.org_surname;
            model.Org_name = orgView.org_name;
            model.Org_company = orgView.org_company;
            model.Org_email = orgView.org_email;

            try
            {
                Validate(model);
                if (orgView.IsEdit)
                {
                    orgRepository.Edit(model);
                    orgView.Message = "Данные организатора успешно изменены.";
                }
                else
                {
                    orgRepository.Add(model);
                    orgView.Message = "Организатор успешно добавлен.";
                }
                orgView.IsSuccess = true;
                LoadAllOrgList();
            }
            catch (Exception ex)
            {
                orgView.IsSuccess = false;
                orgView.Message = ex.Message;
            }
        }

        private void Validate(OrgModel model)
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

        private void DeleteSelectedOrg(object sender, EventArgs e)
        {
            try
            {
                var org = (OrgModel)orgsbindingSource.Current;
                orgRepository.Delete(org.Org_id);
                orgView.IsSuccess = true;
                orgView.Message = "Данные организатора успешно удалены.";
                LoadAllOrgList();
            }
            catch (Exception ex)
            {
                orgView.IsSuccess = false;
                orgView.Message = "Ошибка! Данные организатора не были удалены.";
            }
        }

        private void LoadSelectedOrgToEdit(object sender, EventArgs e)
        {
            var org = (OrgModel)orgsbindingSource.Current;
            orgView.org_id = org.Org_id;
            orgView.org_surname = org.Org_surname;
            orgView.org_name = org.Org_name;
            orgView.org_company = org.Org_company;
            orgView.org_email = org.Org_email;
            orgView.IsEdit = true;
        }

        private void AddOrg(object sender, EventArgs e)
        {
            CleanViewFields();
            orgView.IsEdit = false;
        }

        private void SearchOrg(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.orgView.SearchValue);
            if (emptyValue == false)
            {
                orgList = orgRepository.GetByValue(this.orgView.SearchValue);
            }
            else
                orgList = orgRepository.GetAll();
            orgsbindingSource.DataSource = orgList;
        }

        private void LoadAllOrgList()
        {
            orgList = orgRepository.GetAll();
            orgsbindingSource.DataSource = orgList;
        }
    }
}
