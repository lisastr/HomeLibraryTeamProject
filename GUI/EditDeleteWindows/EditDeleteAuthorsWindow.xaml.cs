﻿using System;
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
    /// Логика взаимодействия для EditDeleteAuthorsWindow.xaml
    /// </summary>
    public partial class EditDeleteAuthorsWindow : Window
    {
        public EditDeleteAuthorsWindow()
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
                    //Нажата кнопка "Сохранить изменения"
                    break;
                case 1:
                    //Нажата кнопка "Удалить выбранного автора"
                    break;
                case 2:
                    //Нажата кнопка "Сортировать"
                    break;
                case 3:
                    //Нажата кнопка "Назад"
                    Close();
                    break;
            }
        }
    }
}
