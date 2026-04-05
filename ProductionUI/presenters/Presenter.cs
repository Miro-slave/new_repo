using ProductionUI.models;
using ProductionUI.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionUI.presrnters
{
    public class Presenter : IPresenter
    {
        private IModel _model;
        private IView _view;
        public Presenter(IModel model, IView view)
        {
            _model = model;
            _view = view;

            view.Presenter = this;
        }

        public void Start()
        {
            _view.ViewProduction(_model.GetData());
        }

        public void AddButtonTapped()
        {
            if (_view.ValidateAdd())
            {
                _view.HideErrors();

                Dictionary<string, string> values = _view.ReadValues();

                ProductDto product = new ProductDto()
                {
                    Name = values["Name"],
                    Number = values["Number"].ToString(),
                    SafetyStockNumber = uint.Parse(values["SafetyStockLevel"])
                };

                _model.TryAdd(product);
                _view.ViewProduction(_model.GetData());
            }
            else
            {
                _view.ViewErrors();
            }
        }
        public void DeleteButtonTapped()
        {
            if (_view.ValidateDelete())
            {
                _view.HideErrors();

                Dictionary<string, string> values = _view.ReadValues();

                ProductDto product = new ProductDto()
                {
                    Name = values["Name"],
                    Number = values["Number"].ToString(),
                    SafetyStockNumber = uint.Parse(values["SafetyStockLevel"])
                };

                _model.TryDelete(product);
                _view.ViewProduction(_model.GetData());
            }
            else
            {
                _view.ViewErrors();
            }
        }

        public void ApplyFiltersButtonTapped()
        {
            Dictionary<string, string> values = _view.ReadValues();

            _model.Filter(values["FilterColumn"], values["FilterPattern"]);
            _model.Sort(values["SortColumn"], values["SortOrder"]);
            _view.ViewProduction(_model.GetData());
        }
    }
}
