using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using MemberList;
using Memberservices;
using EventList;
using Decoration;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for EventPhotography.xaml
    /// </summary>
    public partial class EventPhotography : Window
    {
        string searchId;
        string searchName;
        string searchConatact;
        string searchEmail;
        string searchDemand;
        string removeId;
        double TotalCost;
        double tempphotographyCost;
        public EventPhotography()
        {
            InitializeComponent();
        }

        private void photographersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Members p = (Members)e.AddedItems[0];
            searchId = Convert.ToString(p.MemberId);
            searchName=Convert.ToString(p.MemberName);
            searchConatact = Convert.ToString(p.ContactNumber);
            searchEmail = Convert.ToString(p.Email);
            searchDemand = Convert.ToString(p.Salary);
            idTextBox.Text = searchId;
            nameTextBox.Text = searchName;
            demandTextBox.Text = searchDemand;
                
        }

        private void AddToListButton_Click(object sender, RoutedEventArgs e)
        {
            MemberServices ms = new MemberServices();
            int a = ms.AddtoPhotographer(searchId, searchName, searchConatact, searchEmail, searchDemand);
            if (a == 1)
            {
                addedListDataGrid.ItemsSource = ms.SearchPhotogrpaherhData();
            }
        }
        private void addedListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Members q = (Members)e.AddedItems[0];
            removeId = Convert.ToString(q.MemberId);
            RemoveidTextBox.Text = removeId;
            RemovenameTextBox.Text = Convert.ToString(q.ContactNumber);
            RemovedemandTextBox.Text = Convert.ToString(q.Salary);
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            TotalCost = 0;
            EventCalculation.eventStartTime = Convert.ToString(startTimeTextBox.Text);
            EventCalculation.eventEndTime = Convert.ToString(EndTimeTextBox.Text);
            EventCalculation.printedPhotos = Convert.ToString(PrintedPhotoTextBox.Text);
            EventCalculation.eachPhotoCost = Convert.ToString(eachPhotoCostTextBox.Text);
            int duration = EventCalculation.Duration(Convert.ToDouble(startTimeTextBox.Text), Convert.ToDouble(EndTimeTextBox.Text));
            {
                SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Name,Email,ContactNumber,Salary FROM AddedPhotographer", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Members> SearchList = new List<Members>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SearchList.Add(new Members(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                        TotalCost = TotalCost + (Convert.ToDouble(reader.GetString(4)) * duration);
                    }
                    tempphotographyCost = TotalCost + (Convert.ToDouble(PrintedPhotoTextBox.Text) * Convert.ToDouble(eachPhotoCostTextBox.Text));
                }
                connection.Close();
                EventCalculation.photographyCost = tempphotographyCost;
                MemberServices clr = new MemberServices();
                int j = clr.ClearTable();

                Hide();
                EventDecoration decor = new EventDecoration();
                DecorationService DS = new DecorationService();
                
                connection.Open();
                decor.Show();
            }
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
            searchId = "";
            searchName = "";
            searchConatact ="";
            searchEmail = "";
            searchDemand = "";
            this.Close();
        }

        private void skipButton_Click(object sender, RoutedEventArgs e)
        {
            EventCalculation.eventEndTime = "Not Confirm";
            EventCalculation.photographyCost = 0;
            EventCalculation.printedPhotos = "0";
            EventCalculation.eachPhotoCost = "0";

            EventDecoration ed = new EventDecoration();
            this.Close();
            ed.ShowDialog();
            
        }

        private void RemoveFromAddButon_Click(object sender, RoutedEventArgs e)
        {
            MemberServices update = new MemberServices();
            int i = update.RemoveFromPhotographer(removeId);
                addedListDataGrid.ItemsSource = update.SearchPhotogrpaherhData();
        }
    }
}
