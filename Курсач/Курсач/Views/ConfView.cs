using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач.Models;
using Курсач.Views;
using Курсач.Presenters;
using Курсач._Repository;


namespace Курсач.Views
{
    public partial class ConfView : Form, IConfView
    {
        private string message;
        private bool isSuccess;
        private bool isEdit;

        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public ConfView()
        {
            InitializeComponent();

            tabControlDB.TabPages.Remove(tabPageConfDetail);
            tabControlDB.TabPages.Remove(tabPageOrgDetail);
            tabControlDB.TabPages.Remove(tabPageParticipantDetail);
            tabControlDB.TabPages.Remove(tabPageParticipants);

            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            btnAdd.Click += delegate 
            { 
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Remove(tabPageConfs);
                tabControlDB.TabPages.Add(tabPageConfDetail);
            };

            btnEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Remove(tabPageConfs);
                tabControlDB.TabPages.Add(tabPageConfDetail);

            };
            btnDelete.Click += delegate 
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить конференцию?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnSaveConf.Click += delegate
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty); 
                if (isSuccess)
                {
                    tabControlDB.TabPages.Remove(tabPageConfDetail);
                    tabControlDB.TabPages.Add(tabPageConfs);
                }

                MessageBox.Show(Message);
            };
            btnCancelConf.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlDB.TabPages.Remove(tabPageConfDetail);
                tabControlDB.TabPages.Add(tabPageConfs);
            };
            tbSearchConf.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            

        }

        public int conf_id {
            get { return Convert.ToInt32(tbConfID.Text); }
            set { tbConfID.Text = value.ToString(); }
        }
        public string conf_topic {
            get { return tbConfTopic.Text; }
            set { tbConfTopic.Text = value; }
        }
        public int conf_organizer_id {
            get { return Convert.ToInt32(tbConfOrg.Text); }
            set { tbConfOrg.Text = value.ToString(); }
        }
        public string conf_date {
            get { return tbConfDate.Text; }
            set { tbConfDate.Text = value; }
        }
        public string conf_time {
            get { return tbConfTime.Text; }
            set { tbConfTime.Text = value; }
        }
        public string conf_address {
            get { return tbConfAddress.Text; }
            set { tbConfAddress.Text = value; }
        }
        
        public int max_num_of_participants {
            get { return Convert.ToInt32(tbConfMax.Text); }
            set { tbConfMax.Text = value.ToString(); }
        }
        public string SearchValue {
            get { return tbSearchConf.Text; }
            set { tbSearchConf.Text = value; }
        }
        public bool IsEdit {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccess {
            get { return isSuccess; }
            set { isSuccess = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }

        public void SetConfsListBindingSource(BindingSource confList)
        {
            dataGridViewConfs.DataSource = confList;
        }

        private static ConfView instance;
        public static ConfView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ConfView();
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
