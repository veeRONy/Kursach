using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Models;
using Курсач.Views;

namespace Курсач.Presenters
{
    public class OrgController: _Validator
    {
        MainForm form;

        public OrgController(MainForm form)
        {
            this.form = form;
            form.AddOrgEvent += AddOrg;
            form.CancelOrgEvent += CancelOrg;
            form.EditOrgEvent += EditOrg;
            form.DeleteOrgEvent += DeleteOrg;
            form.SaveOrgEvent += SaveOrg;
            form.SearchOrgEvent += SearchOrg;
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

        private void CancelOrg(object sender, EventArgs e)
        {
            form.org_id = 0;
            form.org_surname = "";
            form.org_name = "";
            form.org_company = "";
            form.org_email = "";
        }

        private void AddOrg(object sender, EventArgs e)
        {
            form.IsEdit = false;
            CancelOrg(sender, e);
        }
    }
}
