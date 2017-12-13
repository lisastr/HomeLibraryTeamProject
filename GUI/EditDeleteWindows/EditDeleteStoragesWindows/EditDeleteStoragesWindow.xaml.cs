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
        EditDeleteStoragesExceptionWindow ExceptionWindow;
        public EditDeleteStoragesWindow()
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
                    //Нажата кнопка "Сохранить изменения элемента мебели"
                    break;
                case 1:
                    //Нажата кнопка "Показать связанные с эл-том мебели области хранения"
                    break;
                case 2:
                    //Нажата кнопка "Удалить выбранный элемент мебели"
                    ExceptionWindow = new EditDeleteStoragesExceptionWindow();
                    ExceptionWindow.Show();
                    break;
                case 3:
                    //Нажата кнопка "Сохранить изменения области хранения"
                    break;
                case 4:
                    //Нажата кнопка "Удалить выбранную область хранения"
                    ExceptionWindow = new EditDeleteStoragesExceptionWindow();
                    ExceptionWindow.Show();
                    break;
                case 5:
                    //Нажата кнопка "Назад"
                    Close();
                    break;
            }
        }
    }
}
