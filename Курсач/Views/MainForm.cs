using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач._Repository;
using Курсач.Models;
using Курсач.Presenters;

namespace Курсач.Views
{
    public partial class MainForm : Form
    {
        public BindingSource confsbindingSource;
        public BindingSource orgsbindingSource;
        public BindingSource partsbindingSource;
        public BindingSource confpartbindingsource;

        public IRepository repository;

        private Button currentBtn;

        public IEnumerable<ConfModel> confList;
        public IEnumerable<ParticipantModel> partList;
        public IEnumerable<OrgModel> orgList;
        public IEnumerable<Conf_Part_Model> confpartList;

        public MainForm()
        {
            InitializeComponent();
            SetBindingSources();
            repository = new Repository(ConfigurationManager.ConnectionStrings["SqliteConnectionString"].ConnectionString);
            

            confList = new List<ConfModel>();
            partList = new List<ParticipantModel>();
            orgList = new List<OrgModel>();
            confpartList = new List<Conf_Part_Model>();

            //new Presenter(this);
            new ConfPresenter(this);
            new OrgPresenter(this);
            new PartPresenter(this);

            LoadAllConfList();
            LoadAllOrgList();
            LoadAllPartList();
            LoadAllConfPartList();

            labelTitle.Text = "Конференции";
            ActivateButton(btnDB);

            tabControlDB.TabPages.Remove(tabPageConfPart);
            tabControlDB.TabPages.Remove(tabPageParts);
            tabControlDB.TabPages.Remove(tabPageConfDetail);
            tabControlDB.TabPages.Remove(tabPageOrgs);
            tabControlDB.TabPages.Remove(tabPageOrgDetail);
            tabControlDB.TabPages.Remove(tabPageReg);
            tabControlDB.TabPages.Remove(tabPagePartDetail);

            btnParticipants.Enabled = true;
            btnDB.Enabled = false;
            btnOrganizers.Enabled = true;

            btnAdd.Click += delegate
            {
                GetOrgs();
                AddConfEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Add(tabPageConfDetail);
                tabControlDB.TabPages.Remove(tabPageConfs);
            };

            btnAddOrg.Click += delegate
            {
                AddOrgEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Add(tabPageOrgDetail);
                tabControlDB.TabPages.Remove(tabPageOrgs);
            };

            btnAddPart.Click += delegate
            {
                AddPartEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Add(tabPagePartDetail);
                tabControlDB.TabPages.Remove(tabPageParts);
                tabControlDB.TabPages.Remove(tabPageConfPart);
                tabControlDB.TabPages.Remove(tabPageReg);
            };

            btnCancelConf.Click += delegate
            {
                CancelConfEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Add(tabPageConfs);
                tabControlDB.TabPages.Remove(tabPageConfDetail);
            };

            btnCancelOrg.Click += delegate
            {
                CancelOrgEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Remove(tabPageOrgDetail);
                tabControlDB.TabPages.Add(tabPageOrgs);
            };

            btnCancelPart.Click += delegate
            {
                CancelPartEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Remove(tabPagePartDetail);
                tabControlDB.TabPages.Add(tabPageParts);
                tabControlDB.TabPages.Add(tabPageConfPart);
            };

            btnCancelReg.Click += delegate
            {
                CancelRegEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Remove(tabPagePartDetail);
                tabControlDB.TabPages.Remove(tabPageReg);
                tabControlDB.TabPages.Add(tabPageParts);
                tabControlDB.TabPages.Add(tabPageConfPart);
            };

            btnEdit.Click += delegate 
            {
                GetOrgs();
                EditConfEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Add(tabPageConfDetail);
                tabControlDB.TabPages.Remove(tabPageConfs);
            };

            btnEditPart.Click += delegate 
            {
                EditPartEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Add(tabPagePartDetail);
                tabControlDB.TabPages.Remove(tabPageParts);
                tabControlDB.TabPages.Remove(tabPageConfPart);
                tabControlDB.TabPages.Remove(tabPageReg);
            };

            btnEditOrg.Click += delegate
            {
                EditOrgEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Add(tabPageOrgDetail);
                tabControlDB.TabPages.Remove(tabPageOrgs);
            };

            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить конференцию?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteConfEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnDeletePart.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить участника?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeletePartEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnDeleteOrg.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить данные организатора?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteOrgEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnDeleteReg.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить регистрацию участника?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteRegEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnSaveConf.Click += delegate
            {
                SaveConfEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess)
                {
                    tabControlDB.TabPages.Remove(tabPageConfDetail);
                    tabControlDB.TabPages.Add(tabPageConfs);
                }
                MessageBox.Show(Message);
            };

            btnSavePart.Click += delegate
            {
                SavePartEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess)
                {
                    tabControlDB.TabPages.Add(tabPageParts);
                    tabControlDB.TabPages.Add(tabPageConfPart);
                    tabControlDB.TabPages.Remove(tabPagePartDetail);
                    tabControlDB.TabPages.Remove(tabPageReg);
                }
                MessageBox.Show(Message);
            };

            btnSaveOrg.Click += delegate
            {
                SaveOrgEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess)
                {
                    tabControlDB.TabPages.Remove(tabPageOrgDetail);
                    tabControlDB.TabPages.Add(tabPageOrgs);
                }
                MessageBox.Show(Message);
            };

            btnSaveReg.Click += delegate
            {
                SaveRegEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess)
                {
                    tabControlDB.TabPages.Remove(tabPageReg);
                    tabControlDB.TabPages.Add(tabPageParts);
                    tabControlDB.TabPages.Add(tabPageConfPart);
                    tabControlDB.TabPages.Remove(tabPagePartDetail);
                }
                MessageBox.Show(Message);
            };

            btnSearch.Click += delegate{ SearchConfEvent?.Invoke(this, EventArgs.Empty);};

            btnSearchPart.Click += delegate{SearchPartEvent?.Invoke(this, EventArgs.Empty);};

            btnSearchOrg.Click += delegate{SearchOrgEvent?.Invoke(this, EventArgs.Empty);};


            btnReg.Click += delegate
            {
                GetConfs();
                RegEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Add(tabPageReg);
                tabControlDB.TabPages.Remove(tabPageParts);
                tabControlDB.TabPages.Remove(tabPagePartDetail);
                tabControlDB.TabPages.Remove(tabPageConfPart);
            };

            tbSearchConf.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchConfEvent?.Invoke(this, EventArgs.Empty);
            };

            tbSearchPart.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchPartEvent?.Invoke(this, EventArgs.Empty);
            };

            tbSearchOrg.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchOrgEvent?.Invoke(this, EventArgs.Empty);
            };

        }

        public event EventHandler SearchConfEvent;
        public event EventHandler SearchPartEvent;
        public event EventHandler SearchOrgEvent;

        public event EventHandler RegEvent;
        public event EventHandler AddConfEvent;
        public event EventHandler AddOrgEvent;
        public event EventHandler AddPartEvent;

        public event EventHandler CancelConfEvent;
        public event EventHandler CancelOrgEvent;
        public event EventHandler CancelPartEvent;
        public event EventHandler CancelRegEvent;

        public event EventHandler EditConfEvent;
        public event EventHandler EditPartEvent;
        public event EventHandler EditOrgEvent;

        public event EventHandler DeleteConfEvent;
        public event EventHandler DeletePartEvent;
        public event EventHandler DeleteRegEvent;
        public event EventHandler DeleteOrgEvent;

        public event EventHandler SaveConfEvent;
        public event EventHandler SavePartEvent;
        public event EventHandler SaveOrgEvent;
        public event EventHandler SaveRegEvent;

        public void LoadAllConfPartList()
        {
            confpartList = repository.GetAllConfPart();
            confpartbindingsource.DataSource = confpartList;
        }

        public void LoadAllPartList()
        {
            partList = repository.GetAllParts();
            partsbindingSource.DataSource = partList;
        }

        public void LoadAllOrgList()
        {
            orgList = repository.GetAllOrgs();
            orgsbindingSource.DataSource = orgList;
        }

        public void LoadAllConfList()
        {
            confList = repository.GetAllConfs();
            confsbindingSource.DataSource = confList;
        }

        private void SetBindingSources()
        {
            this.confsbindingSource = new BindingSource();
            dataGridViewConfs.DataSource = confsbindingSource;

            this.orgsbindingSource = new BindingSource();
            dataGridViewOrgs.DataSource = orgsbindingSource;

            this.partsbindingSource = new BindingSource();
            dataGridViewParticipants.DataSource = partsbindingSource;

            this.confpartbindingsource = new BindingSource();
            dataGridViewConf_Part.DataSource = confpartbindingsource;
        }

       

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
                if (currentBtn != (Button)btnsender)
                {
                    DisableButton();
                    currentBtn = (Button)btnsender;
                    currentBtn.BackColor = Color.FromArgb(207, 6, 53);
                }
        }

        private void DisableButton()
        {
            foreach (Control prevbtn in panelMenu.Controls)
            {
                if (prevbtn.GetType() == typeof(Button))
                {
                    prevbtn.BackColor = Color.FromArgb(52, 51, 76);
                }
            }
        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Участники";
            ActivateButton(btnParticipants);
            tabControlDB.TabPages.Add(tabPageParts);
            tabControlDB.TabPages.Add(tabPageConfPart);
            tabControlDB.TabPages.Remove(tabPageConfs);
            tabControlDB.TabPages.Remove(tabPageConfDetail);
            tabControlDB.TabPages.Remove(tabPageOrgs);
            tabControlDB.TabPages.Remove(tabPageOrgDetail);
            tabControlDB.TabPages.Remove(tabPageReg);
            tabControlDB.TabPages.Remove(tabPagePartDetail);
            btnParticipants.Enabled = false;
            btnDB.Enabled = true;
            btnOrganizers.Enabled = true;
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Конференции";
            ActivateButton(btnDB);
            tabControlDB.TabPages.Add(tabPageConfs);
            tabControlDB.TabPages.Remove(tabPageConfPart);
            tabControlDB.TabPages.Remove(tabPageParts);
            tabControlDB.TabPages.Remove(tabPageConfDetail);
            tabControlDB.TabPages.Remove(tabPageOrgs);
            tabControlDB.TabPages.Remove(tabPageOrgDetail);
            tabControlDB.TabPages.Remove(tabPageReg);
            tabControlDB.TabPages.Remove(tabPagePartDetail);
            btnParticipants.Enabled = true;
            btnDB.Enabled = false;
            btnOrganizers.Enabled = true;
        }

        private void btnOrganizers_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Организаторы";
            ActivateButton(btnOrganizers);
            tabControlDB.TabPages.Add(tabPageOrgs);
            tabControlDB.TabPages.Remove(tabPageConfPart);
            tabControlDB.TabPages.Remove(tabPageParts);
            tabControlDB.TabPages.Remove(tabPageConfDetail);
            tabControlDB.TabPages.Remove(tabPageConfs);
            tabControlDB.TabPages.Remove(tabPageOrgDetail);
            tabControlDB.TabPages.Remove(tabPageReg);
            tabControlDB.TabPages.Remove(tabPagePartDetail);
            btnParticipants.Enabled = true;
            btnDB.Enabled = true;
            btnOrganizers.Enabled = false;
        }



        

        

        // ---------------------Конференция-----------------------//
        public int conf_id
        {
            get { return Convert.ToInt32(tbConfID.Text); }
            set { tbConfID.Text = value.ToString(); }
        }
        public string conf_topic
        {
            get { return tbConfTopic.Text; }
            set { tbConfTopic.Text = value; }
        }
        public string conf_organizer_id
        {
            get { return cbOrgs.Text; }

            set { cbOrgs.Text = value; }
        }
        public string conf_date
        {
            get { return tbConfDate.Text; }
            set { tbConfDate.Text = value; }
        }
        public string conf_time
        {
            get { return tbConfTime.Text; }
            set { tbConfTime.Text = value; }
        }
        public string conf_address
        {
            get { return tbConfAddress.Text; }
            set { tbConfAddress.Text = value; }
        }

        public int max_num_of_participants
        {
            get { return Convert.ToInt32(tbConfMax.Text); }
            set { tbConfMax.Text = value.ToString(); }
        }
        public string SearchValueConf
        {
            get { return tbSearchConf.Text; }
            set { tbSearchConf.Text = value; }
        }



        //---------------------Участники----------------------------------//
        public int part_id
        {
            get { return Convert.ToInt32(tbPartID.Text); }
            set { tbPartID.Text = value.ToString(); }
        }
        public string part_surname
        {
            get { return tbPartSurname.Text; }
            set { tbPartSurname.Text = value; }
        }
        public string part_name
        {
            get { return tbPartName.Text; }
            set { tbPartName.Text = value; }
        }

        public string part_email
        {
            get { return tbPartEmail.Text; }
            set { tbPartEmail.Text = value; }
        }

        public string SearchValuePart
        {
            get { return tbSearchPart.Text; }
            set { tbSearchPart.Text = value; }
        }




        //-------------------------Организаторы-----------------------//

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
        public string SearchValueOrg
        {
            get { return tbSearchOrg.Text; }
            set { tbSearchOrg.Text = value; }
        }


        //---------------Конф-Уч----------------------//

        public string CONF_ID
        {
            get { return cbConfs.Text; }
            set { cbConfs.Text = value; }
        }
        public int PART_ID
        {
            get { return Convert.ToInt32(tbPART_ID.Text); }
            set { tbPART_ID.Text = value.ToString(); }
        }
        public string TOPIC
        {
            get { return tbTopic.Text; }
            set { tbTopic.Text = value; }
        }



        //-----------------------------------------------//
        //-----------------------------------------------//


        private string message;
        private bool isSuccess;
        private bool isEdit;

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



        public void GetOrgs()
        {
            IEnumerable<OrgModel> orgList = new List<OrgModel>();
            orgList = repository.GetAllOrganizers();

            cbOrgs.Items.Clear();
            foreach (var org in orgList)
            {
                cbOrgs.Items.Add(org.Org_id);
            }
        }

        public void GetConfs()
        {
            IEnumerable<ConfModel> confList = new List<ConfModel>();

            confList = repository.GetAllConfs();

            cbConfs.Items.Clear();
            foreach (var conf in confList)
            {
                cbConfs.Items.Add(conf.Conf_id);
            }
        }

      
    }
}
