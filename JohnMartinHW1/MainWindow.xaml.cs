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

namespace JohnMartinHW1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int clicks = 1;

        public int numOfClicks
        {
            get { return clicks; }
            set
            {
                if (value > 0)
                {
                    clicks = value;
                }
                else
                {
                    clicks = 0;
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private int getNumberOfClicks()
        {
            return numOfClicks;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Button has been clicked " + numOfClicks++ + " times";
        }
    }
}
