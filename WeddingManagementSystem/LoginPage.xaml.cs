using Memberservices;
using System.Data.SqlClient;
using System.Windows;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();

        }
        public static string userId;

        private void logInButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            userId=userIdTextBox.Text;
            string password = passwordTextBox.Password;
            MemberServices ms = new MemberServices();
            ms.getById(userId);
            SqlCommand cmd = new SqlCommand(ms.getById(userId), connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (reader.GetString(0).Equals(userId))
                {
                    if (reader.GetString(1).Equals(password))
                    {
                        using (MainWindow main = new MainWindow())
                        {
                            this.Close();
                            main.ShowDialog();
                        }
                    }
                    else MessageBox.Show("Invalid Pssword or UserId");
                }
                else MessageBox.Show("Invalid Pssword or UserId");
            }
            else MessageBox.Show("Invalid Pssword or UserId");

        }
    }
}
