using System;
using System.Windows;
using Decoration;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for AddDecorationForm.xaml
    /// </summary>
    public partial class AddDecorationForm : Window
    {
        public AddDecorationForm()
        {
            InitializeComponent();
            itemTextBox.Items.Add("Stage");
            itemTextBox.Items.Add("HomeLight");
            itemTextBox.Items.Add("StreetLight");
            itemTextBox.Items.Add("Gate");
            itemTextBox.Items.Add("Palanquin");
        }

        private void decorationAddButton_Click(object sender, RoutedEventArgs e)
        {
            string item =Convert.ToString(itemTextBox.Text);
            string type =Convert.ToString(typeTextBox.Text);
            string cost = Convert.ToString(costTextBox.Text);
            Decoration.DecorationList Dl = new Decoration.DecorationList(item, type, cost);
            Decoration.DecorationService S1 = new DecorationService();
            int i = S1.AddDecorationItem(Dl);
            if(i==1)
            {
                Close();
            }

        }
    }
}
