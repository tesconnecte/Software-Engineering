using Order_System.Commands;
using Order_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Order_System.Views
{
    public class MainWindowViewModel : BaseViewModel
    {
        public string AddOrderButtonContent { get; private set; }
        public string ViewOrderButtonContent { get; private set; }

        public ICommand AddOrderButtonCommand { get; private set; }
        public ICommand ViewOrderButtonCommand { get; private set; }

        public MainWindowViewModel()
        {
            AddOrderButtonContent = "Add Order";
            ViewOrderButtonContent = "View Orders";

            AddOrderButtonCommand = new RelayCommand(AddOrderButtonClick);
            ViewOrderButtonCommand = new RelayCommand(ViewOrderButtonClick);


        }

        private void ViewOrderButtonClick()
        {
            throw new NotImplementedException();
        }

        private void AddOrderButtonClick()
        {
            throw new NotImplementedException();
        }
    }
}
