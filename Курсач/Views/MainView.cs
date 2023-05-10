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
    public partial class MainView : Form, IMainView
    {
        private Button currentBtn;

        public event EventHandler ShowStartView;
        public event EventHandler ShowInfo;
        public event EventHandler ShowConfsView;
        public event EventHandler ShowPartsView;
        public event EventHandler ShowOrgsView;

        public MainView()
        {
            InitializeComponent();
            btnDB.Click += delegate { 
                ShowConfsView?.Invoke(this, EventArgs.Empty);
                labelTitle.Text = "Конференции";
                ActivateButton(btnDB);
            };

            btnInfo.Click += delegate 
            {
                ShowInfo?.Invoke(this, EventArgs.Empty);
                labelTitle.Text = "Справка";
                ActivateButton(btnInfo);
            };

            btnConfs.Click += delegate
            {
                ShowStartView?.Invoke(this, EventArgs.Empty);
                labelTitle.Text = "Меню";
                ActivateButton(btnConfs);
            };

            btnParticipants.Click += delegate
            {
                ShowPartsView?.Invoke(this, EventArgs.Empty);
                labelTitle.Text = "Участники";
                ActivateButton(btnParticipants);
            };

            btnOrganizers.Click += delegate
            {
                ShowOrgsView?.Invoke(this, EventArgs.Empty);
                labelTitle.Text = "Организаторы";
                ActivateButton(btnOrganizers);
            };

            labelTitle.Text = "Меню";
            StartView startView = StartView.GetInstance((MainView)this);
            startView.MdiParent = (Form)this;
            startView.Show();
            ActivateButton(btnConfs);
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

        
    }
}
