using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataBindingLists.Annotations;

namespace DataBindingLists
{
    public class Employee : INotifyPropertyChanged
    {
        private String _name;

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value; 
                OnPropertyChanged();
            }
        }

        private String _title;

        public String Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>
            {
                new Employee
                {
                    Name = "Max Kimambo",
                    Title = "Programmer"

                },
                new Employee
                {
                    Name = "Little Billy ",
                    Title = "Code warrior"

                },
                new Employee
                {
                    Name = "Little John",
                    Title = "Code master"

                },
                new Employee
                {
                    Name = "Little Robin",
                    Title = "Code smith"

                }
            };

            return employees; 
        }
    }
}
