using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач._Repository;
using Курсач.Models;

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
            tabControlPart.TabPages.Remove(tabPageRegDetail);

            // поиск участника
            btnSearchPart.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbSearchPart.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            btnAddPart.Click += delegate
            {
                // добавление участника
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControlPart.TabPages.Remove(tabPageParts);
                tabControlPart.TabPages.Add(tabPagePartDetail);
                tabControlPart.TabPages.Remove(tabPageRegDetail);
                tabControlPart.TabPages.Remove(tabPageRegs);
            };

            btnEditPart.Click += delegate
            {
                // редактирование участника
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlPart.TabPages.Remove(tabPageParts);
                tabControlPart.TabPages.Add(tabPagePartDetail);
                tabControlPart.TabPages.Remove(tabPageRegDetail);
                tabControlPart.TabPages.Remove(tabPageRegs);

            };
            btnDeletePart.Click += delegate
            {
                // удаление участника
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
                // сохранение
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess)
                {
                    tabControlPart.TabPages.Remove(tabPagePartDetail);
                    tabControlPart.TabPages.Add(tabPageParts);
                    tabControlPart.TabPages.Remove(tabPageRegDetail);
                    tabControlPart.TabPages.Add(tabPageRegs);
                }

                MessageBox.Show(Message);
            };
            btnCancelPart.Click += delegate
            {
                // отмена добавления/редактирования участника
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlPart.TabPages.Remove(tabPagePartDetail);
                tabControlPart.TabPages.Add(tabPageParts);
                tabControlPart.TabPages.Remove(tabPageRegDetail);
                tabControlPart.TabPages.Add(tabPageRegs);
            };


            btnReg.Click += delegate
            {
                // переходим на страницу регистрации
                AddPartInConfEvent?.Invoke(this, EventArgs.Empty);
                tabControlPart.TabPages.Remove(tabPagePartDetail);
                tabControlPart.TabPages.Add(tabPageRegDetail);
                tabControlPart.TabPages.Remove(tabPageParts);
                tabControlPart.TabPages.Remove(tabPageRegs);
                GetConfs();
            };


            btnSaveReg.Click += delegate
            {
                isSuccess = false;
                // сохранение регистрации
                SaveRegEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess)
                {
                    tabControlPart.TabPages.Remove(tabPagePartDetail);
                    tabControlPart.TabPages.Add(tabPageParts);
                    tabControlPart.TabPages.Remove(tabPageRegDetail);
                    tabControlPart.TabPages.Add(tabPageRegs);
                }
                MessageBox.Show(Message);
            };

            btnCancelReg.Click += delegate
            {
                // отмена регистрации
                CancelRegEvent?.Invoke(this, EventArgs.Empty);
                tabControlPart.TabPages.Remove(tabPagePartDetail);
                tabControlPart.TabPages.Add(tabPageParts);
                tabControlPart.TabPages.Remove(tabPageRegDetail);
                tabControlPart.TabPages.Add(tabPageRegs);
            };



            btnDeleteReg.Click += delegate
            {
                // удаление регистрации участника (в таблице Conf_Part)
                var result = MessageBox.Show("Вы уверены, что хотите удалить регистрацию участника?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteRegEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };

        }

        // отображаемые поля для ввода информации
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

        public string part_email {
            get { return tbPartEmail.Text; }
            set { tbPartEmail.Text = value; }
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



        public string CONF_ID 
        { 
            get { return cbConfs.Text;}
            set { cbConfs.Text = value;}
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


        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler DeleteRegEvent;
        public event EventHandler SaveRegEvent;
        public event EventHandler CancelRegEvent;
        public event EventHandler AddPartInConfEvent;

        public void SetPartListBindingSource(BindingSource partList, BindingSource confpartList)
        {
            dataGridViewParticipants.DataSource = partList;
            dataGridViewConf_Part.DataSource = confpartList;
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

        public void GetConfs()
        {
            var confList = new List<ConfModel>();
            IConfRepository confRepository = new ConfRepository(ConfigurationManager.ConnectionStrings["SqliteConnectionString"].ConnectionString);
            confList = (List<ConfModel>)confRepository.GetAllConfs();

            cbConfs.Items.Clear();
            foreach (var conf in confList)
            {
                cbConfs.Items.Add(conf.Conf_id);
            }
        }
    }
}
