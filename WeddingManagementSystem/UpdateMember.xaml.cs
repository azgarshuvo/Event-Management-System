using System.Windows;
using Memberservices;
namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for UpdateMember.xaml
    /// </summary>
    public partial class UpdateMember : Window
    {
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            MemberServices ms = new MemberServices();
            ms.UpdateMember(UpdatenameTextBoxa.Text,UpdatepositionTextBoxa.Text,UpdatedateOfBirthTextBoxa.Text,UpdatecontactNoTextBoxa.Text,UpdatejoinDateTextBoxa.Text,UpdateemailTextBoxa.Text,UpdateaddressTextBoxa.Text, UpdatesalaryTextBoxa.Text);
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
