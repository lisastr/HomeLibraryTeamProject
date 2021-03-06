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
using GUI.EditDeleteWindows;
using Logic;

namespace GUI
{
    /// <summary>
    /// Логика взаимодействия для FunctionWindow.xaml
    /// </summary>
    public partial class FunctionWindow : Window
    {
        public Window BooksWindow { get; set; }
        public Window AuthorsWindow { get; set; }
        public Window StoragesWindow { get; set; }
        public IContext DB { get; set; }

        public int FunctionIndicator { get; set; }

        public FunctionWindow(int tag, string title, IContext context)
        {
            InitializeComponent();
            FunctionIndicator = tag;
            TitleTextBlock.Text = title;
            DB = context;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var tag = button.Tag as string;
            var tagInt = Convert.ToInt32(tag);
            switch (tagInt)
            {
                case 0:
                    //нажата кнопка "Книги"
                    switch (FunctionIndicator) 
                        //Инициализация объектов разных классов, в зависимости от функции системы:
                        //0 - read
                        //1 - create
                        //2 - edit & delete
                    {
                        case 0:
                            //BooksWindow = new ...
                            break;
                        case 1:
                            //BooksWindow = new ...
                            break;
                        case 2:
                            BooksWindow = new EditDeleteBooksWindow();
                            BooksWindow.Show();
                            break;
                    }
                    break;
                case 1:
                    //нажата кнопка "Авторы"
                    switch (FunctionIndicator)
                    {
                        //Инициализация объектов разных классов, в зависимости от функции системы:
                        //0 - read
                        //1 - create
                        //2 - edit & delete
                        case 0:
                            //AuthorsWindow = new ...
                            break;
                        case 1:
                            //AuthorsWindow = new ...
                            break;
                        case 2:
                            AuthorsWindow = new EditDeleteAuthorsWindow(DB);
                            AuthorsWindow.Show();
                            break;
                    }
                    break;
                case 2:
                    //нажата кнопка "Места хранения"
                    switch (FunctionIndicator)
                    {
                        //Инициализация объектов разных классов, в зависимости от функции системы:
                        //0 - read
                        //1 - create
                        //2 - edit & delete
                        case 0:
                            //StoragesWindow = new ...
                            break;
                        case 1:
                            //StoragesWindow = new ...
                            break;
                        case 2:
                            StoragesWindow = new EditDeleteStoragesWindow();
                            StoragesWindow.Show();
                            break;
                    }
                    break;
                case 3:
                    //нажата кнопка "Назад"
                    Close();
                    break;
            }
        }
    }
}
