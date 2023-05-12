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
    public class OrgPresenter: Presenter
    {
        private IOrgView orgView;
        private IRepository repository;
        private BindingSource orgsbindingSource;
        private IEnumerable<OrgModel> orgList;

        public OrgPresenter(IOrgView orgView, IRepository repository)
        {
            this.orgView = orgView;
            this.repository = repository;
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
                    repository.EditOrg(model);
                    orgView.Message = "Данные организатора успешно изменены.";
                }
                else
                {
                    repository.AddOrg(model);
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

        private void DeleteSelectedOrg(object sender, EventArgs e)
        {
            try
            {
                var org = (OrgModel)orgsbindingSource.Current;
                repository.DeleteOrg(org.Org_id);
                orgView.IsSuccess = true;
                orgView.Message = "Данные организатора успешно удалены.";
                LoadAllOrgList();
            }
            catch
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
                orgList = repository.GetByValueOrgs(this.orgView.SearchValue);
            }
            else
                orgList = repository.GetAllOrgs();
            orgsbindingSource.DataSource = orgList;
        }

        private void LoadAllOrgList()
        {
            orgList = repository.GetAllOrgs();
            orgsbindingSource.DataSource = orgList;
        }
    }
}
