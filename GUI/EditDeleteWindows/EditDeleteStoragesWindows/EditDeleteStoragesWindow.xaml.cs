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

namespace GUI.EditDeleteWindows
{
    /// <summary>
    /// Логика взаимодействия для EditDeleteStoragesWindow.xaml
    /// </summary>
    public partial class EditDeleteStoragesWindow : Window
    {
        EditDeleteStoragesExceptionWindow TheEditDeleteStoragesExceptionWindow;
        public EditDeleteStoragesWindow()
        {
            InitializeComponent();
        }

        private void DemoButton_Click(object sender, RoutedEventArgs e)
        {
            TheEditDeleteStoragesExceptionWindow = new EditDeleteStoragesExceptionWindow();
            TheEditDeleteStoragesExceptionWindow.Show();
        }
    }
}
