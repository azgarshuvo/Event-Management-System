using System.Windows;
using MemberList;
using Memberservices;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for AddNewMember.xaml
    /// </summary>
    public partial class AddNewMember : Window
    {
        public AddNewMember()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void addMemberButton_Click(object sender, RoutedEventArgs e)
        {
            MemberList.Members newMember = new Members(nameTextBoxa.Text, positionTextBoxa.Text, dateOfBirthTextBoxa.Text, contactNoTextBoxa.Text, joinDateTextBoxa.Text, emailTextBoxa.Text, addressTextBoxa.Text, salaryTextBoxa.Text);
            MemberServices service = new MemberServices();
            int i = service.AddMembers(newMember);

            if (i == 1)
            {
                MessageBox.Show("Successfull");
            }
            else
            {
                MessageBox.Show("Failed");
            }
            Close();
            /* MemberServices sr = new MemberServices();
              MainWindow k = new MainWindow();
              k.MembersListGrid.ItemsSource = sr.LoadData();*/
        }
    }
}
