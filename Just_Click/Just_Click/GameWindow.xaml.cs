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
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public GameWindow()
        {
            InitializeComponent();

        }

        private int _score = 0;

        private int _click = 1;

        private bool _istwo = false;

        private bool _isten = false;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public int Click { get => _click; set => _click = value; }
        public bool Istwo { get => _istwo; set => _istwo = value; }
        public bool Isten { get => _isten; set => _isten = value; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Score = Score + Click;
            score.Content = "Score: " + Score;


            if (Score >= 100 && Istwo == false)
            {
                twobtn.IsEnabled = true;
                Istwo = true;
            }

            if (Score >= 1000 && Isten == false)
            {
                tenbtn.IsEnabled = true;
                Isten = true;
            }
        }

        private void xbtn_Click(object sender, RoutedEventArgs e)
        {
            var records = new List<object>
            {
                new { Player_Name = this.Name, HiScore = this.Score },
            };

            if (!File.Exists("Highscore.csv"))
            {
                var config1 = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";", Encoding = Encoding.UTF8 };
                using (var writer = new StreamWriter("Highscore.csv"))
                using (var csv = new CsvWriter(writer, config1))
                {
                    csv.WriteRecords(records);
                }
                return;
            }
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
                Delimiter = ";"
            };

            using (var stream = File.Open("Highscore.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(records);
            }

            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Score < 100)
            {
                MessageBox.Show("You need 100 clicks to unlock this!");
            }
            else
            {
                Click = 2;
                twobtn.IsEnabled = false;
            }
        }

        private void tenbtn_Click(object sender, RoutedEventArgs e)
        {
            if (Score < 1000)
            {
                MessageBox.Show("You need 1000 clicks to unlock this!");
            }
            else
            {
                Click = 10;
                tenbtn.IsEnabled = false;
            }
        }

        private void secbtn_Click(object sender, RoutedEventArgs e)
        {
            if (Score < 10000)
            {
                MessageBox.Show("You need 10000 clicks to unlock this!");
            }
            else
            {
                ImageBrush b = new ImageBrush();
                b.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Secret_backg.png"));
                this.Background = b;
            }
        }
    }
}
