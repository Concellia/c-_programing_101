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

namespace WPF_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match { Completion= 70, Score1=1,Score2=2,Team1="Mamelodi Sundowns",Team2="Kaizer Chiefs"});
            matches.Add(new Match { Completion = 30, Score1 = 0, Score2 = 2, Team1 = "South Africa", Team2 = "Nigeria" });
            matches.Add(new Match { Completion = 10, Score1 = 1, Score2 = 1, Team1 = "Banyana Banyana", Team2 = "Bafana Bafana" });
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: \n"+ 
                    (lbMatches.SelectedItem as Match).Team1+" "+
                     (lbMatches.SelectedItem as Match).Score1 + " \n"+
                      (lbMatches.SelectedItem as Match).Team2 + " "+
                       (lbMatches.SelectedItem as Match).Score2 + "\n"+
                       (90-(lbMatches.SelectedItem as Match).Completion) + " minutes left before game ends."
                      
                    );
            }
        }
    }

    public class Match 
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int  Completion { get; set; }
    }

}
