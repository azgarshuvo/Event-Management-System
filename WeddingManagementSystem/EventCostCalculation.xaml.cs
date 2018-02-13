using System.Windows;
using EventList;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for EventCostCalculation.xaml
    /// </summary>
    public partial class EventCostCalculation : Window
    {
        public EventCostCalculation()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            EventService ES = new EventService();
            CustomerInfo CI = new CustomerInfo();
            CI.eventIdTextBox.Text = ES.CreateEventId();
            this.Close();
            CI.Show();
        }
        private void addVatDiscountButton_Click_1(object sender, RoutedEventArgs e)
        {
            totalCostTextBlock.Text = EventCalculation.CalculationWithVat(vatTextBox.Text, discountTextBox.Text);
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
            EventCalculation.discount=0;
            EventCalculation.totalCostWithVat = 0;
            this.Close();
        }
    }
}
