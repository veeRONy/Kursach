using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Views;
using Курсач.Models;
using Курсач._Repository;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Курсач.Presenters
{
    public class MainPresenter
    {

        private IMainView mainView;
        IRepository repository;

        public MainPresenter(IMainView mainView, string sqliteConnectionString)
        {
            this.mainView = mainView;
            this.mainView.ShowConfsView += ShowConfsView;
            this.mainView.ShowPartsView += ShowPartsView;
            this.mainView.ShowOrgsView += ShowOrgsView;
            this.mainView.ShowInfo += ShowInfo;

            repository = new Repository(sqliteConnectionString);
            ShowConfsView(this, EventArgs.Empty);
        }

        private void ShowInfo(object sender, EventArgs e)
        {
            Info infoForm = Info.GetInstance((MainView)mainView);
            infoForm.MdiParent = (Form)mainView;
            infoForm.Show();
        }

        private void ShowConfsView(object sender, EventArgs e)
        {
            IConfView confView = ConfView.GetInstance((MainView)mainView);
            new ConfPresenter(confView, repository);
            
        }

        private void ShowPartsView(object sender, EventArgs e)
        {
            IPartView partview = ParticipantsView.GetInstance((MainView)mainView);
            new ParticipantPresenter(partview, repository);

        }

        private void ShowOrgsView(object sender, EventArgs e)
        {
            IOrgView orgview = OrgView.GetInstance((MainView)mainView);
            new OrgPresenter(orgview, repository);

        }
    }
}
