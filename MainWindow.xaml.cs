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

namespace MineSweeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateGrid(8);
        }

        void ClearGrid()
        {
            gameGrid.Children.Clear();
            gameGrid.RowDefinitions.Clear();
            gameGrid.ColumnDefinitions.Clear();
        }

        void CreateGrid(int gameMode)
        {
            ClearGrid();

            int count = 1;

            for (int i = 0; i < gameMode; i++)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();
                gameGrid.ColumnDefinitions.Add(columnDefinition);
                for (int j = 0; j < gameMode; j++)
                {
                    RowDefinition rowDefinition = new RowDefinition();
                    gameGrid.RowDefinitions.Add(rowDefinition);

                    Button button = new Button();
                    button.Content = count.ToString();
                    button.Name = "button" + count.ToString();

                    Grid.SetColumn(button, j);
                    Grid.SetRow(button, i);
                    gameGrid.Children.Add(button);

                    count++;
                }
            }
        }

        private void Begginer_Click(object sender, RoutedEventArgs e)
        {
            CreateGrid(8);
        }

        private void Advanced_Click(object sender, RoutedEventArgs e)
        {
            CreateGrid(16);
        }

        private void Expert_Click(object sender, RoutedEventArgs e)
        {
            CreateGrid(24);
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Rules_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}
