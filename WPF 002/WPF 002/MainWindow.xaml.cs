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

namespace WPF_002
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int MyProperty {
            get { return (int)GetValue(dependencyProperty); }
            set { SetValue(dependencyProperty, value); } 
        }

        public static readonly DependencyProperty dependencyProperty = DependencyProperty.Register("My Property",typeof(int),typeof(MainWindow),new PropertyMetadata(0));
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddFruit(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(sender);
            MessageBox.Show(sender.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Was clicked");
        }

       public int MyProperties()
        {
            return 0;
        }
    }
}
