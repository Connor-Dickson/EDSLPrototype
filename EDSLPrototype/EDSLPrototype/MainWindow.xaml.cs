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
using System.Collections.ObjectModel;

namespace EDSLPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filepath = @"C:\Users\102051563\source\repos\EDSLPrototype\Files\data.txt";
        public List<int> roundList { get; set; }
        public List<string> datList = new List<string>();
        public List<string> divs = new List<string>();

        public MainWindow()
        {
            startDateDropBox = new ComboBox();
            divisionDropBox = new ComboBox();
            
            InitializeComponent();
            for(int d = 0; d < divs.Count(); d++)
            {
                divs.Add(d.ToString());
                divisionDropBox.Items.Add(d);
            }
        }

        private void displayResultsScreen(object sender, RoutedEventArgs e)
        {
            ObservableCollection<ResultsClass> resultsData = new ObservableCollection<ResultsClass>();
            var ResultsScreen = new Results(resultsData);
            ResultsScreen.Show();
            Close();
        }

        /*public void generateDates(object sender, RoutedEventArgs e)
        {
            
            dateList.Items.Add(startDateDropBox.Text);
            datList.Add("15/06/2019");
            datList.Add("16/06/2019");
            datList.Add("17/06/2019");
            datList.Add("18/06/2019");
            datList.Add("19/06/2019");
            datList.Add("20/06/2019");
            datList.Add("21/06/2019");
            datList.Add("22/06/2019");
            datList.Add("23/06/2019");
            datList.Add("24/06/2019");
            datList.Add("25/06/2019");
            for (int i = 0; i < datList.Count; i++)
            {
                dateList.Items.Add(datList[i]);
            }

        }*/
        //Click="generateDates"

        private void saveSeason(object sender, RoutedEventArgs e)
        {
            Season test = new Season(seasonNameDropBox.Text, int.Parse(noOfRoundsTextBox.Text), startDateDropBox.Text, datList);
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                dateList.Items.Add(startDateDropBox.Text);
                datList.Add("15/06/2019");
                datList.Add("16/06/2019");
                datList.Add("17/06/2019");
                datList.Add("18/06/2019");
                datList.Add("19/06/2019");
                datList.Add("20/06/2019");
                datList.Add("21/06/2019");
                datList.Add("22/06/2019");
                datList.Add("23/06/2019");
                datList.Add("24/06/2019");
                datList.Add("25/06/2019");
                for (int i = 0; i < datList.Count; i++)
                {
                    dateList.Items.Add(datList[i]);
                }
            }
        }

        private void EditDatesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateDrawButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Generated Draw");
        }
    }
}
