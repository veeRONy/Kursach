using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач.Views
{
    public interface IConfView
    {
        int conf_id { get; set; }
        string conf_topic { get; set; }
        string conf_organizer_id { get; set; }
        string conf_date { get; set; }
        string conf_time { get; set; }
        string conf_address { get; set; }
        int max_num_of_participants { get; set; }
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

        void SetConfsListBindingSource(BindingSource confList);
        void Show();

    }
}
