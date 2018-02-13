using System.Windows;
using EventList;
using System.Data.SqlClient;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for EventDecoration.xaml
    /// </summary>
    public partial class EventDecoration : Window
    {
        public EventDecoration()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT type,cost FROM DecorationList WHERE (item ='Gate') OR (item ='gate')", connection);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    gateTextbox.Items.Add(reader1.GetString(0));
                }
            }
            connection.Close();
            connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT type,cost FROM DecorationList WHERE (item ='Stage') OR (item ='stage')", connection);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    stageComboBox.Items.Add(reader2.GetString(0));
                }
            }
            connection.Close();
            connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT type,cost FROM DecorationList WHERE (item ='HomeLight') OR (item ='homelight')", connection);
            SqlDataReader reader3 = cmd3.ExecuteReader();

            if (reader3.HasRows)
            {
                while (reader3.Read())
                {
                    homeLightComboBox.Items.Add(reader3.GetString(0));
                }
            }
            connection.Close();
            connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd4 = new SqlCommand("SELECT type,cost FROM DecorationList WHERE (item ='StreetLight') OR (item ='streetlight')", connection);
            SqlDataReader reader4 = cmd4.ExecuteReader();

            if (reader4.HasRows)
            {
                while (reader4.Read())
                {
                    streetLightComboBox.Items.Add(reader4.GetString(0));
                }
            }
            connection.Close();
            connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd5 = new SqlCommand("SELECT type,cost FROM DecorationList WHERE (item ='Palanquin') OR (item ='palanquin')", connection);
            SqlDataReader reader5 = cmd5.ExecuteReader();

            if (reader5.HasRows)
            {
                while (reader5.Read())
                {
                    planaquinComboBox.Items.Add(reader5.GetString(0));
                }
            }
            connection.Close();
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            EventCalculation.stage = stageComboBox.Text;
            EventCalculation.homelight = homeLightComboBox.Text;
            EventCalculation.homelight = homeLightDurationCombBox.Text;
            EventCalculation.streetlight = streetLightComboBox.Text;
            EventCalculation.streetlightDeuration = streetlightDeuration.Text;
            EventCalculation.gate = gateTextbox.Text;
            EventCalculation.planaquin = planaquinComboBox.Text;
            EventCalculation.totalDecorationCost(stageComboBox.Text, homeLightComboBox.Text,homeLightDurationCombBox.Text, streetLightComboBox.Text, streetlightDeuration.Text, gateTextbox.Text, planaquinComboBox.Text);
            Centers cn = new Centers();
            this.Close();
            cn.ShowDialog();
        }

        private void skipButton_Click(object sender, RoutedEventArgs e)
        {
            Centers cn = new Centers();
            this.Close();
            cn.ShowDialog();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            EventCalculation.eventDate = "";
            EventCalculation.eventStartTime = "";
            EventCalculation.eventEndTime = "";
            EventCalculation.printedPhotos = "";
            EventCalculation.eachPhotoCost = "";
            EventCalculation.photographyCost = 0;
            EventCalculation.decorationCost = 0;
            EventCalculation.stage = "";
            EventCalculation.homelight = "";
            EventCalculation.homelightDuration = "";
            EventCalculation.streetlight = "";
            EventCalculation.streetlightDeuration = "";
            EventCalculation.gate = "";
            EventCalculation.planaquin = "";
            EventCalculation.centerName = "";
            EventCalculation.centerLoaction = "";
            EventCalculation.totalCostWithoutVat = 0;
            EventCalculation.totalcenterCost = 0;
            EventCalculation.eventDuration = "";
            EventCalculation.CostStage = 0;
            EventCalculation.CostHomeLight = 0;
            EventCalculation.CostStreetLight = 0;
            EventCalculation.CostGate = 0;
            EventCalculation.CostPlanaquin = 0;
            EventCalculation.vat = 0;
            EventCalculation.discount = 0;
            EventCalculation.totalCostWithVat = 0;
            this.Close();
        }
    }
}
