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
    /// Логика взаимодействия для EditDeleteStoragesExceptionWindow.xaml
    /// </summary>
    public partial class EditDeleteStoragesExceptionWindow : Window
    {
        public EditDeleteStoragesExceptionWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            MessageBoxResult result = MessageBox.Show(
                "Необходимо присвоить недостающие места хранения прежде чем закрыть окно.",
                "Сообщение",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}
