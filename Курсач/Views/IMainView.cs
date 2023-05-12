using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Views
{
    public interface IMainView
    {
        event EventHandler ShowInfo;
        event EventHandler ShowConfsView;
        event EventHandler ShowPartsView;
        event EventHandler ShowOrgsView;
    }
}
