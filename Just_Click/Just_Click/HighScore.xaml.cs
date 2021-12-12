using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
    /// Interaction logic for HighScore.xaml
    /// </summary>
    public partial class HighScore : Window
    {
        public object records = new List<object>();

        public HighScore()
        {
            InitializeComponent();

            if (File.Exists("Highscore.csv"))
            {

                var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";", Encoding = Encoding.UTF8 };
                using (var reader = new StreamReader("Highscore.csv"))
                using (var csv = new CsvReader(reader, config))
                {
                    var anonymousTypeDefinition = new
                    {
                        Player_Name = String.Empty,
                        HiScore = default(int)
                    };
                    records = csv.GetRecords(anonymousTypeDefinition).ToList();
                    hs.ItemsSource = (IEnumerable<object>)records;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }
    }
}
