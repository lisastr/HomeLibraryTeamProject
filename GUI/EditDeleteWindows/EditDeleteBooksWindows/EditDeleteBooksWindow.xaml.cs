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
    /// Логика взаимодействия для EditDeleteBooksWindow.xaml
    /// </summary>
    public partial class EditDeleteBooksWindow : Window
    {
        public EditDeleteBooksAuthorsWindow EDAuthorsWindow { get; set; }
        public EditDeleteBooksStoragesWindow EDStoragesWindow { get; set; }
        public EditDeleteBooksQuantityIncreasedWindow QuantityIncreasedWindow { get; set; }
        public EditDeleteBooksQuantityDecreasedWindow QuantityDecreasedWindow { get; set; }

        public EditDeleteBooksWindow()
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
                    //Нажата кнопка "Сохранить изменения в свойствах книги"
                    QuantityIncreasedWindow = new EditDeleteBooksQuantityIncreasedWindow();
                    QuantityIncreasedWindow.Show();
                    QuantityDecreasedWindow = new EditDeleteBooksQuantityDecreasedWindow();
                    QuantityDecreasedWindow.Show();
                    break;
                case 1:
                    //Нажата кнопка "Удалить выбранную книгу"
                    break;
                case 2:
                    //Нажата кнопка "Редактировать или удалить авторов выбранной книги"
                    EDAuthorsWindow = new EditDeleteBooksAuthorsWindow();
                    EDAuthorsWindow.Show();
                    break;
                case 3:
                    //Нажата кнопка "Редактировать или удалить места хранения выбранной книги"
                    EDStoragesWindow = new EditDeleteBooksStoragesWindow();
                    EDStoragesWindow.Show();
                    break;
                case 4:
                    //Нажата кнопка "Назад"
                    Close();
                    break;
            }
        }
    }
}
