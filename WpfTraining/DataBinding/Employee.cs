using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataBinding.Annotations;

namespace DataBinding
{
    public class Employee : INotifyPropertyChanged

    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }

        private string _Title;

        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value; 
                OnPropertyChanged();
            }
        }
        

        public static Employee GetEmployee()
        {
            return new Employee {Name = "Max", Title = "Software engineer"}; 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
