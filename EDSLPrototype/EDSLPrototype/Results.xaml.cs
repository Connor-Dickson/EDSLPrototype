using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EDSLPrototype
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {


        public ObservableCollection<ResultsClass> resultsData { get; set; }

        public Results(ObservableCollection<ResultsClass> resultsData)
        {
            
            InitializeComponent();
            

        }

        private void displaySeasonScreen(object sender, RoutedEventArgs e)
        {
            var SeasonScreen = new MainWindow();
            SeasonScreen.Show();
            Close();
        }

        private void EditRoundButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (seasonDropBox.Text != null && divisionDropBx.Text != null && roundDropBox.Text != null && roundDateTextBox.Text != null)
            {
                //List<ResultsClass> resultsData = new List<ResultsClass>();
                //resultsData.Add(a);
                resultsData = new ObservableCollection<ResultsClass>()
                {
                new ResultsClass(1, "Ringwood", "Wantirna", 0, 0),
                new ResultsClass(2, "Murrumbeena", "Lilydale", 0, 0),
                new ResultsClass(3, "Beaconsfield Upper", "Oakleigh", 0, 0)
                };
                resultsGrid.ItemsSource = resultsData;
                resultsGrid.DataContext = resultsData;
            }
        }

        private void UpdateResultsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Results Updated");
        }

        private void UpdateLadderButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ladder Updated");
        }

        
    }
}
