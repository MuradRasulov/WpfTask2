using Firebase.Auth;
using Firebase.Auth.Providers;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Firebase.Database;
using Firebase.Database.Query;

namespace WpfTaskDesktop
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow :Window
    {
        private UserCredential userCredential;
        public TaskWindow (UserCredential user)
        {
            InitializeComponent( );
            this.userCredential = user;
            var userr = userCredential.User;
            var task_name = ("users/djWdCaVd2hXWgwLQbsMrUf4BiDv2/tasks/0");
        }

        private void GoToAddTaskWindow (object sender, RoutedEventArgs e)
        {
            AddTaskWindow w = new AddTaskWindow( );
            w.Show( );
            this.Close( );
        }

        private void GoToEditWindow (object sender, RoutedEventArgs e)
        {
            EditTaskWindow w = new EditTaskWindow( );
            w.Show( );
            this.Close( );
        }
        private async void Base ()
        {
            List taskList = new List();
            var firebase = new FirebaseClient("https://taskplanner-9ea53-default-rtdb.firebaseio.com/");
            var task = await firebase
                .Child("users")
                .Child("djWdCaVd2hXWgwLQbsMrUf4BiDv2")
                .Child("tasks")
                .OnceAsync<UserTasks>();

            List<UserTasks> tasks = task.Select(t => t.Object).ToList( );

        }

        private void load_test (object sender, RoutedEventArgs e)
        {
            Base();
        }
    }
}
       
