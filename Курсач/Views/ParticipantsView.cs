using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач._Repository;

namespace Курсач.Views
{
    public partial class ParticipantsView : Form, IPartView
    {
        private string message;
        private bool isSuccess;
        private bool isEdit;

        public ParticipantsView()
        {
            InitializeComponent();

            tabControlPart.TabPages.Remove(tabPagePartDetail);

            btnSearchPart.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbSearchPart.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            btnAddPart.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControlPart.TabPages.Remove(tabPageParts);
                tabControlPart.TabPages.Add(tabPagePartDetail);
            };

            btnEditPart.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlPart.TabPages.Remove(tabPageParts);
                tabControlPart.TabPages.Add(tabPagePartDetail);

            };
            btnDeletePart.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить участника?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnSavePart.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess)
                {
                    tabControlPart.TabPages.Remove(tabPagePartDetail);
                    tabControlPart.TabPages.Add(tabPageParts);
                }

                MessageBox.Show(Message);
            };
            btnCancelPart.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlPart.TabPages.Remove(tabPagePartDetail);
                tabControlPart.TabPages.Add(tabPageParts);
            };

        }

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
        public string part_topic 
        {
            get { return tbPartTopic.Text; }
            set { tbPartTopic.Text = value; }
        }
        public string part_email {
            get { return tbPartEmail.Text; }
            set { tbPartEmail.Text = value; }
        }
        public int conf_ID 
        {
            get { return Convert.ToInt32(tbConf_ID.Text); }
            set { tbConf_ID.Text = value.ToString(); }
        }
        public string SearchValue 
        {
            get { return tbSearchPart.Text; }
            set { tbSearchPart.Text = value; }
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

        public void SetPartListBindingSource(BindingSource partList)
        {
            dataGridViewParticipants.DataSource = partList;
        }

        private static ParticipantsView instance;
        public static ParticipantsView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ParticipantsView();
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
