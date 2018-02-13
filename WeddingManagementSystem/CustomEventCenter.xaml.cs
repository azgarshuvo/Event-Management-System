using System;
using System.Windows;
using EventList;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for CustomEventCenter.xaml
    /// </summary>
    public partial class CustomEventCenter : Window
    {
        public CustomEventCenter()
        {
            InitializeComponent();
        }

        private void addCenterButton_Click(object sender, RoutedEventArgs e)
        {
            EventCalculation.centerName = centerNameTextBox.Text;
            EventCalculation.centerLoaction = locationTextBox.Text;
            EventCalculation.eventStartTime = startTimeTextBox.Text;    
            EventCostCalculation EC = new EventCostCalculation();
            EC.photographyCostBox.Text = Convert.ToString(EventCalculation.photographyCost);
            EC.decorationCostBox.Text = Convert.ToString(EventCalculation.decorationCost);
            EC.CenterCostBox.Text = Convert.ToString(EventCalculation.totalcenterCost);
            EC.withoutVatBox.Text = EventCalculation.CalculationWithoutVat(EventCalculation.photographyCost,EventCalculation.decorationCost,EventCalculation.totalcenterCost);
            Close();
            EC.Show();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
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
