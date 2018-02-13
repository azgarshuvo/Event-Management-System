using EventList;
using System.Windows;
using CenterJobs;
namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for CreateEventInvoice.xaml
    /// </summary>
    public partial class CreateEventInvoice : Window
    {
        public CreateEventInvoice()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
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
            EventCalculation.customerContactNumber = "";
            EventCalculation.customerEmail = "";
            EventCalculation.customerAddress = "";
            EventCalculation.eventId = "";
            EventCalculation.advancePay = "";
            EventCalculation.remainingPay = "";
             this.Close();
        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog prnt = new System.Windows.Controls.PrintDialog();

            if (prnt.ShowDialog() == true)
            {
                prnt.PrintVisual(EventInvoiceGrid, "Printing Grid");
            }
            EventsList EL = new EventsList(eventIdTextBlock.Text, EventCalculation.eventDate, EventCalculation.eventStartTime, EventCalculation.photographyCost, EventCalculation.decorationCost, EventCalculation.totalcenterCost, EventCalculation.vat, EventCalculation.discount, EventCalculation.totalCostWithVat, EventCalculation.advancePay, EventCalculation.remainingPay, EventCalculation.customerName, EventCalculation.customerContactNumber, EventCalculation.customerEmail, EventCalculation.customerAddress,"Pending");
            EventService service = new EventService();
            int x = service.AddEvent(EL);
            CenterService cs = new CenterService();
            cs.BookCenter(eventIdTextBlock.Text, EventCalculation.centerId);
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
            EventCalculation.customerContactNumber = "";
            EventCalculation.customerEmail = "";
            EventCalculation.customerAddress = "";
            EventCalculation.eventId = "";
            EventCalculation.advancePay = "";
            EventCalculation.remainingPay = "";
            this.Close();
        }
    }
}
