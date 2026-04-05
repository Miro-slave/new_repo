using ProductionUI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionUI.presrnters
{
    public interface IPresenter
    {
        void Start();

        void AddButtonTapped();

        void DeleteButtonTapped();

        void ApplyFiltersButtonTapped();
    }
}
