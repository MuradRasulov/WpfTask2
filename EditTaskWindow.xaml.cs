using Firebase.Auth;
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
using System.Windows.Shapes;

namespace WpfTaskDesktop
{
    /// <summary>
    /// Логика взаимодействия для EditTaskWindow.xaml
    /// </summary>
    public partial class EditTaskWindow : Window
    {
        public EditTaskWindow()
        {
            InitializeComponent();
        }

        private void GoToBackWindow (object sender, RoutedEventArgs e)
        {
            //TaskWindow w = new TaskWindow();
            //w.Show( );
            this.Close( );
        }

        private void GoToTaskWindow (object sender, RoutedEventArgs e)
        {
            //TaskWindow w = new TaskWindow();
            //w.Show( );
            this.Close( );
        }

        private void RemoveButton (object sender, RoutedEventArgs e)
        {

        }
    }
}
