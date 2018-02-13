using System.Windows;
using Memberservices;
namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for ChangeMyPassword.xaml
    /// </summary>
    public partial class ChangeMyPassword : Window
    {
        public ChangeMyPassword()
        {
            InitializeComponent();
        }

        private void CancelChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ConfirmChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            string old = OldPasswordText.Text;
            string nw = NewPasswordText.Text;
            string id = LoginPage.userId;
            MemberServices ms = new MemberServices();
           if( ms.UpdatePassword(old, nw, id) == 1)
            {
                MessageBox.Show("update done");
            }
           else
            {
                MessageBox.Show("Wrong Information");

            }
        }
    }
}
