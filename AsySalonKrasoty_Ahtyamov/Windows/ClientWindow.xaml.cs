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

namespace AsySalonKrasoty_Ahtyamov.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void btCangeClient_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извениете эта функция пока не достпуна");
        }
       

        private void btAddClient_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddClient add = new AddClient();
            add.ShowDialog();
        }

        private void btDellClient_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извениете эта функция пока не достпуна");
        }

        private void btDown_Click(object sender, RoutedEventArgs e)
        {
            Windows.MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }
    }
}
