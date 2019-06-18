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
using System.IO;

namespace EDSLPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filepath = @"C:\Users\102051563\source\repos\EDSLPrototype\Files\data.txt";
        public List<int> roundList { get; set; }
        public List<string> datList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void displayResultsScreen(object sender, RoutedEventArgs e)
        {
            var ResultsScreen = new Results();
            ResultsScreen.Show();
            Close();
        }

        public void generateDates(object sender, RoutedEventArgs e)
        {
            
            dateList.Items.Add(startDateDropBox.Text);
            dateList.Items.Add("15/06/2019");
        }

    }
}
