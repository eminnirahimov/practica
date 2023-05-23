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

namespace Avtoriz
{
    /// <summary>
    /// Логика взаимодействия для registr.xaml
    /// </summary>
    public partial class registr : Window
    {
        public registr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (parol.Text == pwparol.Text)
            {
                if (mail.Text.Contains("@mail.ru") == true)
                {
                    string path = @"E:\F\УЧЕБА\Литвинов\";
                    StreamWriter wr = new StreamWriter(path + "2.txt");
                    foreach (var line in login.Text) wr.Write(line);
                    wr.Write(" ");
                    foreach (var line in parol.Text) wr.Write(line);
                    wr.Close();

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else MessageBox.Show("Почта имеет не верный формат");
            }
            else MessageBox.Show("Введенные пароли не совпадают");
        }
    }
}
