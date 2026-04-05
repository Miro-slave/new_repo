using ProductionUI.presrnters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionUI.views
{
    public interface IView
    {
        IPresenter Presenter { set; }
        void ViewProduction(DataView production);

        void ViewErrors();

        void HideErrors();

        bool ValidateAdd();

        bool ValidateDelete();
        Dictionary<string, string> ReadValues();
    }
}
