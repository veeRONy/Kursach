using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач.Views
{
    public interface IOrgView
    {
        int org_id { get; set; }
        string org_surname { get; set; }
        string org_name { get; set; }
        string org_company { get; set; }
        string org_email { get; set; }
        int conf_id { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }


        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetOrgsListBindingSource(BindingSource orgList);
        void Show();
    }
}
