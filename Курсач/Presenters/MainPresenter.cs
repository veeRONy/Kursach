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
        private readonly string sqliteConnectionString;

        public MainPresenter(IMainView mainView, string sqliteConnectionString)
        {
            this.mainView = mainView;
            this.sqliteConnectionString = sqliteConnectionString;
            this.mainView.ShowConfsView += ShowConfsView;
            this.mainView.ShowInfo += ShowInfo;
            this.mainView.ShowStartView += ShowStartView;
            this.mainView.ShowPartsView += ShowPartsView;
            this.mainView.ShowOrgsView += ShowOrgsView;
        }

        private void ShowConfsView(object sender, EventArgs e)
        {
            IConfView confview = ConfView.GetInstance((MainView)mainView);
            IConfRepository repository = new ConfRepository(sqliteConnectionString);
            new ConfPresenter(confview, repository);
            
        }

        private void ShowInfo(object sender, EventArgs e)
        {
            Info infoForm = Info.GetInstance((MainView)mainView);
            infoForm.MdiParent = (Form)mainView;
            infoForm.Show();
        }

        private void ShowStartView(object sender, EventArgs e)
        {
            StartView startView = StartView.GetInstance((MainView)mainView);
            startView.MdiParent = (Form)mainView;
            startView.Show();
        }

        private void ShowPartsView(object sender, EventArgs e)
        {
            IPartView partview = ParticipantsView.GetInstance((MainView)mainView);
            IPartRepository repository = new PartRepository(sqliteConnectionString);
            new ParticipantPresenter(partview, repository);

        }

        private void ShowOrgsView(object sender, EventArgs e)
        {
            IOrgView orgview = OrgView.GetInstance((MainView)mainView);
            IOrgRepository repository = new OrgRepository(sqliteConnectionString);
            new OrgPresenter(orgview, repository);

        }
    }
}
