using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Commands;

namespace WpfApplication1
{
    public class MainVM : INotifyPropertyChanged
    {
        public MainVM()
        {
            InitialiseComponents();
        }

        private void InitialiseComponents()
        {
            LoginCommand = new RelayCommand(loginCommandMethod);
        }

        private RelayCommand _loginCommand;

        public RelayCommand LoginCommand
        {
            get { return _loginCommand; }
            private set { _loginCommand = value; }
        }

        private void loginCommandMethod(object parameter)
        {
            // do something
        }
        private string searchKey;

        public string SearchKey
        {
            get { return searchKey; }
            set { searchKey = value; OnPropertyChanged("SearchKey"); }
        }


        #region INotify
        public void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged; 
        #endregion
    }
}
