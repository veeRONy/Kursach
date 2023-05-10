using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач.Views
{
    public interface IPartView
    {
        int part_id { get; set; }
        string part_surname { get; set; }
        string part_name { get; set; }
        string part_topic { get; set; }
        string part_email { get; set; }
        int conf_ID { get; set; }
       
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

        void SetPartListBindingSource(BindingSource confList);
        void Show();
    }
}
