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
using System.IO;
namespace Football
{
    /// <summary>
    /// Interaction logic for Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }
        public static string log = "";
        private void exitbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void autorizationbutton_Click(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text == "")
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (passwordBox.Password == "")
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            FileStream fl = new FileStream("C:\\Users\\User\\Desktop\\logins.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fl);
            bool ok = false;
            bool okl = false;
            string login = "";
            Hashing h = new Hashing();
            string pass = h.hash(passwordBox.Password);
            while (!sr.EndOfStream)
            {
                string l = sr.ReadLine();
                string p = sr.ReadLine();
                if (l==loginBox.Text)
                {
                    okl = true;
                    if (p==pass)
                    {
                        ok = true;
                        login = l;
                    }
                }
            }
            if (ok==true)
            {
                log = login;
                this.Close();
            }
            else if (okl==true)
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                MessageBox.Show("Несуществующий логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
