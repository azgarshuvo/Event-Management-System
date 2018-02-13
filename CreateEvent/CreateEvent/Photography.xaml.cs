using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CreateEvent
{
    /// <summary>
    /// Interaction logic for Photography.xaml
    /// </summary>
    public partial class Photography : Window
    {
        public Photography()
        {
            InitializeComponent();
        }

        private void photographyButton_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
