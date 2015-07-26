﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Employee emp; 
        public MainWindow()
        {
            InitializeComponent();
            emp = new Employee()
            {
                Title = "Janitor",
                Name = "John Doe"
            };

            DataContext = emp; 

        }


        private void BtnEmployee_OnClick(object sender, RoutedEventArgs e)
        {
            emp.Name = "New name";
            emp.Title = "New Title"; 
        }
    }
}
