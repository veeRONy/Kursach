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
        string part_email { get; set; }
       
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }


        string CONF_ID { get; set; }
        int PART_ID { get; set; }
        string TOPIC { get; set; }


        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler DeleteRegEvent;
        event EventHandler SaveRegEvent;
        event EventHandler CancelRegEvent;
        event EventHandler AddPartInConfEvent;


        void SetPartListBindingSource(BindingSource partList, BindingSource confpartList);
        void Show();
    }
}
