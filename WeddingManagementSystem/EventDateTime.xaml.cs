using System;
using System.Windows;
using EventList;
using Memberservices;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for EventDateTime.xaml
    /// </summary>
    public partial class EventDateTime : Window
    {
        public EventDateTime()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            EventPhotography photography = new EventPhotography();
            EventCalculation.date=Convert.ToDateTime(eventDateTextBox.Text);
            EventCalculation.eventDate=Convert.ToString(eventDateTextBox.Text);
            EventCalculation.eventStartTime=Convert.ToString(eventStartTimeTextBox.Text);
            photography.startTimeTextBox.Text=eventStartTimeTextBox.Text;
            Close();
            MemberServices ms = new MemberServices();
            photography.photographersDataGrid.ItemsSource = ms.PhotographerData("Photographer", "photographer");
            photography.ShowDialog();
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
            Close();
        }
    }
}
