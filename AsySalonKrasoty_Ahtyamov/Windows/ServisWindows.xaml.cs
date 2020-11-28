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
    /// Логика взаимодействия для ServisWindows.xaml
    /// </summary>
    public partial class ServisWindows : Window
    {
        public ServisWindows()
        {
            InitializeComponent();
        }

        private void btCangeServis_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извениете эта функция пока не достпуна");
        }

       

        private void btAddServis_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddServisWindow addServisWindow = new AddServisWindow();
            addServisWindow.ShowDialog();
        }

        private void btDellServis_Click(object sender, RoutedEventArgs e)
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
