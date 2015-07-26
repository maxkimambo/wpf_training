using System;
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

namespace ControlsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
           
            var userData = new StringBuilder();
            userData.Append(String.Format("Full name: {0}", TxtFullName.Text)); 
            userData.Append(String.Format("Gender: {0}", RdMale.IsChecked != null && (bool) RdMale.IsChecked ? "Male" : "Female"));

           userData.Append(String.Format("Your hardware: {0}",(bool) ChkDesktop.IsChecked? "Desktop": "")); 
           userData.Append(String.Format("{0}",(bool) ChkLaptop.IsChecked? "Laptop": "")); 
           userData.Append(String.Format("{0}",(bool) ChkTablet.IsChecked? "Tablet": "")); 
            userData.Append(String.Format("Start date: {0}", CalStartDate.SelectedDate));

            MessageBox.Show(CboOccupation.SelectedValue.ToString()); 

            MessageBox.Show(userData.ToString()); 
        }
    }
}
