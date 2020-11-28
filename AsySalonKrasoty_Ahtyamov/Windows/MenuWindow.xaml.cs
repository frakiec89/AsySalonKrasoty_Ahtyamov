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
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переводит на форму список  сервисов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUsligi_Click(object sender, RoutedEventArgs e)
        {
            Windows.ServisWindows servisWindows = new ServisWindows();
            servisWindows.Show();
            this.Close();
        }

        /// <summary>
        /// Переводит на  форму список клиентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClient_Click(object sender, RoutedEventArgs e)
        {
            Windows.ClientWindow clientWindow = new ClientWindow();
            clientWindow.Show();
            this.Close();
        }


        /// <summary>
        /// Переводит на  форму список клиентов записанных на сервис
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClientServis_Click(object sender, RoutedEventArgs e)
        {
            Windows.ClientServisWindow clientServisWindow = new ClientServisWindow();
            clientServisWindow.Show();
            this.Close();
        }

        
        
        /// <summary>
        /// Переводит на форму  записать клинта на  услугу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGoServis_Click(object sender, RoutedEventArgs e)
        {
            Windows.ClienrServisGoWindow clienrServisGoWindow = new ClienrServisGoWindow();
            clienrServisGoWindow.Show();
            this.Close();
        }


        /// <summary>
        /// Возвращает на стартовое окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDown_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
