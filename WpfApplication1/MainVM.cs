using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using WpfApplication1.Commands;
using Model;

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
            List = new List<ExampleItem>();
            for (int i = 0; i < 100; i++)
            {
                List.Add(new ExampleItem { Name = "Gabe"+i.ToString(), Age = 2 * i });
            }
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

        private List<ExampleItem> _list;

        public List<ExampleItem> List
        {
            get { return _list; }
            set { _list = value; OnPropertyChanged("List"); }
        }


        Dispatcher _dispatcher = Dispatcher.CurrentDispatcher;
        //Time consuming operation
        private void LongTask()
        {
            Thread.Sleep(5000);
            //in here if you need to send something to the UI thread like an event use it like so:
            _dispatcher.Invoke(new Action(() =>
            {
                //some code here to invoke an event
                if (ComponentsLoaded != null)
                    ComponentsLoaded(this, new EventArgs { });
            }));
        }

        private ICommand _command;
        //This is the command to be used instead of click event handler
        public ICommand Command
        {
            get { return _command; }
            private set { _command = value; }
        }
        //method associated with ICommand
        void commandMethod(object parameter)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(multiThreadTask));
        }
        //the task to be started on another thread
        void multiThreadTask(object parameter)
        {
            LongTask();
        }

        protected void ExecuteOnUIThread(Action _t)
        {
            _dispatcher.Invoke(_t);
        }
        protected void ExecuteOnUIThread(Action<object> _tp, object parameter)
        {
            _dispatcher.Invoke(() =>
            {
                _tp.Invoke(parameter);
            });
        }

        public event EventHandler ComponentsLoaded;

        private void OnLoaded()
        {
            _dispatcher.Invoke(() => {
                if (ComponentsLoaded != null)
                {
                    ComponentsLoaded(this, new EventArgs { });
                }
            });
        }

        #region INotify
        private void OnPropertyChanged(string prop)
        {
            _dispatcher.Invoke(() => {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            });
        }
        public event PropertyChangedEventHandler PropertyChanged; 
        #endregion
    }
}
