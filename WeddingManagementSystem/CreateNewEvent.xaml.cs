using System.Windows;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for CreateNewEvent.xaml
    /// </summary>
    public partial class CreateNewEvent : Window
    {
        public CreateNewEvent()
        {
            InitializeComponent();
        }

        private void mixedButton_Click(object sender, RoutedEventArgs e)
        {
            EventDateTime ed = new EventDateTime();
            ed.Show();
            Close();
        }
    }
}
