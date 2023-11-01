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

namespace WPF_001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.FontSize = 26;
            btn.Height = 100;
            btn.Width = 300;

            ContentControl contentControl = new ContentControl();
            WrapPanel wrapPanel = new WrapPanel();
            TextBlock txt = new TextBlock();
            txt.Text = "Hello";
            txt.Foreground = Brushes.Pink;
            wrapPanel.Children.Add(txt);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "There";
            txt2.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Tiyiselani";
            txt3.Foreground = Brushes.Teal;
            wrapPanel.Children.Add(txt3);

            contentControl.Content = wrapPanel;
            btn.Content = contentControl;
            grid.Children.Add(btn);
        }
    }
}
