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

namespace GUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FunctionWindow ReadWindow { get; set; }
        public FunctionWindow CreateWindow { get; set; }
        public FunctionWindow EditDeleteWindow { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var tag = button.Tag as string;
            var tagInt = Convert.ToInt32(tag);
            switch (tagInt)
            {
                case 0:
                    ReadWindow = new FunctionWindow(tagInt, "Просмотреть данные:");
                    ReadWindow.Show();
                    break;
                case 1:
                    CreateWindow = new FunctionWindow(tagInt, "Добавить новые данные:");
                    CreateWindow.Show();
                    break;
                case 2:
                    EditDeleteWindow = new FunctionWindow(tagInt, "Редактировать или удалить данные:");
                    EditDeleteWindow.Show();
                    break;
                case 3:
                    Close();
                    break;
            }
        }
    }
}
