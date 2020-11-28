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
    /// Запись  клиента  на  услгугу
    /// </summary>
    public partial class ClienrServisGoWindow : Window
    {
        public ClienrServisGoWindow()
        {
            InitializeComponent();
        }


        private void btDown_Click(object sender, RoutedEventArgs e)
        {
            Windows.MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }


        /// <summary>
        /// Добавляет клинта на запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            var rez = MessageBox.Show("Вы действительно хотете записать  клинета на услугу?", "Сообшение", 
               MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (rez == MessageBoxResult.Yes) // если нажали да
            {
                MessageBox.Show("Запись прошла успешно");
            }
        }
    }
}
