using System.Windows;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for SetSecurityQuestion.xaml
    /// </summary>
    public partial class SetSecurityQuestion : Window
    {
        public SetSecurityQuestion()
        {
            InitializeComponent();
        }

        private void SecurityQuestionCancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
