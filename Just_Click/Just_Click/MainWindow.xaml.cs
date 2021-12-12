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

namespace Just_Click
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            PlayerName pn = new PlayerName();
            pn.Show();
            this.Hide();
        }

        private void High_Scores_Click(object sender, RoutedEventArgs e)
        {
            HighScore hs = new HighScore();
            hs.Show();
            this.Hide();
        }
    }
}
