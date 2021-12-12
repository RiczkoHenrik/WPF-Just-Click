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

namespace Just_Click
{
    /// <summary>
    /// Interaction logic for PlayerName.xaml
    /// </summary>
    public partial class PlayerName : Window
    {
        public PlayerName()
        {
            InitializeComponent();
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            if (!(getname.Text == ""))
            {
                GameWindow gw = new GameWindow();
                gw.Name = getname.Text;
                gw.Show();
                this.Hide();
            }
        }
    }
}
