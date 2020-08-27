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
using CsQuery;

namespace WhatWatchToday
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CQ dom = CQ.CreateFromUrl("https://www.ivi.ru/collections/best-movies/page4");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            //CQ dom = CQ.CreateFromUrl("https://www.ivi.ru/collections/best-movies/page4");
            Random rnd = new Random();

            string[] list_films = new string[29];

            int i = 0;
            foreach (IDomObject item in dom.Find(".nbl-slimPosterBlock__title"))
            {
                if (i >= 29)
                {
                    break;
                }
                else
                {

                    list_films[i] = item.TextContent;
                    i++;

                }
            }

            //MessageBox.Show(list_films[rnd.Next(0, list_films.Length)]);

            int num_film = rnd.Next(0, list_films.Length);
            MessageBox.Show($"Название: {list_films[num_film]}");

        }
    }
}
