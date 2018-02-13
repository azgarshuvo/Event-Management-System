using System.Windows;
using EventList;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for CustomerInfo.xaml
    /// </summary>
    public partial class CustomerInfo : Window
    {
        public CustomerInfo()
        {
            InitializeComponent();
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
            EventCalculation.customerName = "";
            EventCalculation.customerContactNumber="";
            EventCalculation.customerEmail="";
            EventCalculation.customerAddress="";
            EventCalculation.eventId="";
            EventCalculation.advancePay="";
            EventCalculation.remainingPay="";
            Close();
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        { 
            EventCalculation.customerName = nameTextBox.Text;
            EventCalculation.customerContactNumber = contactNoTextBox.Text;
          EventCalculation.customerEmail= emailTextBox.Text;
            EventCalculation.customerAddress=addressTextBox.Text;
           EventCalculation.advancePay=advancePayTextBox.Text;
            CreateEventInvoice CEI = new CreateEventInvoice();
            CEI.eventIdTextBlock.Text = eventIdTextBox.Text;
            CEI.eventDateTextBlock.Text = EventCalculation.eventDate;
            CEI.startTimeTextBlock.Text = EventCalculation.eventStartTime;
            CEI.photographyTextBlock.Text = EventCalculation.getPhotographyCost();
            CEI.decorationTextBlock.Text = EventCalculation.getDecorationCost();
            CEI.centerTextBlock.Text = EventCalculation.getCenterCost();
            CEI.vatTextBlock.Text = EventCalculation.getVat() + " % ";
            CEI.discountTextBlock.Text = EventCalculation.getDiscount() + " % ";
            CEI.totalcostTextBlock.Text = EventCalculation.getTotalCost();
            CEI.advancePaymentTextBlock.Text = EventCalculation.advancePay;
            CEI.remainingTextBlock.Text = EventCalculation.CalculateRemaining();
            CEI.Show();
            Close();
        }
    }
}
