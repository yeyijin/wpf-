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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly LoginViewModel _loginViewModel = new LoginViewModel();
        public MainWindow()
        {
            InitializeComponent();

            //数据源中心
            base.DataContext = _loginViewModel;

            _loginViewModel.FirstCommand = new FirstCommand(CheckRight);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"{_loginViewModel.UserName}--{_loginViewModel.Password}");

        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("剪切了");
        }


        private void CheckRight()
        {
            if (_loginViewModel.UserName == "1" && _loginViewModel.Password == "1")
                MessageBox.Show("ok");
        }
    }
}
