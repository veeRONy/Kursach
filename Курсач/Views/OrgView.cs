using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач.Views
{
    public partial class OrgView : Form, IOrgView
    {
        private bool isSuccess;
        private string message;
        private bool isEdit;

        public OrgView()
        {
            InitializeComponent();

            tabControlOrgs.TabPages.Remove(tabPageOrgDetail);

            btnSearchOrg.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbSearchOrg.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            btnAddOrg.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControlOrgs.TabPages.Remove(tabPageOrgs);
                tabControlOrgs.TabPages.Add(tabPageOrgDetail);
            };

            btnEditOrg.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlOrgs.TabPages.Remove(tabPageOrgs);
                tabControlOrgs.TabPages.Add(tabPageOrgDetail);

            };
            btnDeleteOrg.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить данные организатора?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnSaveOrg.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess)
                {
                    tabControlOrgs.TabPages.Remove(tabPageOrgDetail);
                    tabControlOrgs.TabPages.Add(tabPageOrgs);
                }

                MessageBox.Show(Message);
            };
            btnCancelOrg.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlOrgs.TabPages.Remove(tabPageOrgDetail);
                tabControlOrgs.TabPages.Add(tabPageOrgs);
            };


        }

        public int org_id 
        {
            get { return Convert.ToInt32(tbOrgID.Text); }
            set { tbOrgID.Text = value.ToString(); }
        }
        public string org_surname 
        {
            get { return tbOrgSurname.Text; }
            set { tbOrgSurname.Text = value; }
        }
        public string org_name 
        {
            get { return tbOrgName.Text; }
            set { tbOrgName.Text = value; }
        }
        public string org_company 
        {
            get { return tbCompany.Text; }
            set { tbCompany.Text = value; }
        }
        public string org_email
        {
            get { return tbOrgEmail.Text; }
            set { tbOrgEmail.Text = value; }
        }
        public string SearchValue 
        {
            get { return tbSearchOrg.Text; }
            set { tbSearchOrg.Text = value; }
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccess 
        {
            get { return isSuccess; }
            set { isSuccess = value; }
        }
        public string Message 
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetOrgsListBindingSource(BindingSource orgList)
        {
            dataGridViewOrgs.DataSource = orgList;
        }


        private static OrgView instance;
        

        public static OrgView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new OrgView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;

            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
