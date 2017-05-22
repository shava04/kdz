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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return; 
            }
            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("Пароль потвержден неверно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            FileStream fl = new FileStream("C:\\Users\\User\\Desktop\\logins.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fl);
            bool ok = true;
            while(!sr.EndOfStream)
            {
                string l = sr.ReadLine();
                if (l==textBox.Text)
                {
                    ok = false;
                }
                l = sr.ReadLine();
            }
            sr.Close();
            fl.Close();
            if (ok==false)
            {
                MessageBox.Show("Данный логин уже занят", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                FileStream f1 = new FileStream("C:\\Users\\User\\Desktop\\logins.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr1 = new StreamReader(f1);
                List<string> logins = new List<string>(0);
                List<string> passwords = new List<string>(0);
                while (!sr1.EndOfStream)
                {
                    logins.Add(sr1.ReadLine());
                    passwords.Add(sr1.ReadLine());
                }
                sr1.Close();
                f1.Close();
                Hashing h = new Hashing();
                string pass = h.hash(textBox1.Text);
                logins.Add(textBox.Text);
                passwords.Add(pass);
                FileStream f = new FileStream("C:\\Users\\User\\Desktop\\logins.txt", FileMode.Open, FileAccess.Write);
                StreamWriter sw = new StreamWriter(f);
                for (int i=0; i<logins.Count; i++)
                {
                    sw.WriteLine(logins[i]);
                    sw.WriteLine(passwords[i]);
                }
                sw.Close();
                f.Close();
                this.Close();
            }
          
        }
    }
}
