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
using System.IO;

namespace Avtoriz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string path = @"E:\F\УЧЕБА\Литвинов\2.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            registr reg = new registr();
            reg.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FileStream fileStream = new FileStream(@"E:\F\УЧЕБА\Литвинов\2.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            fileStream.Close();
            string[] str = File.ReadAllText(path).Split(' ');

            if(logintxt.Text == str[0] && passtxt.Text == str[1])
            {
                MessageBox.Show("Успех");
                newform newm = new newform();
                newm.Show();
                this.Close();
            }
        }
    }
}
