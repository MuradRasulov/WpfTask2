using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTaskDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FirebaseAuthClient client;

        public MainWindow()
        {
            InitializeComponent( );
        }

        private async void next_window_btn (object sender, RoutedEventArgs e)
        {
            try
            {
                UserCredential userCredential = await client.SignInWithEmailAndPasswordAsync(textbox_Email.Text, passwordbox_Password.Text);
                
                TaskWindow w = new TaskWindow( userCredential);
                w.Show( );
                this.Close( );
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Load (object sender, RoutedEventArgs e)
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyA_9sP8RpUUM-HoZ1H8hOaMbkIkMffolKo",
                AuthDomain = "taskplanner-9ea53.firebaseapp.com",
                Providers = new FirebaseAuthProvider [ ]
                {
                    new EmailProvider()
                }
            };
            client = new FirebaseAuthClient(config);
        }
    }
}
