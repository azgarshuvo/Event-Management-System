using System;
using System.Windows;
using EventList;
using CenterJobs;
namespace WeddingManagementSystem

{
    /// <summary>
    /// Interaction logic for Centers.xaml
    /// </summary>
    public partial class Centers : Window
    {
        static string SearchCenterId;
        string SearchCenterName;
        public Centers()
        {
            InitializeComponent();
            CenterService cs = new CenterService();
            centerInfoDataGrid.ItemsSource = cs.ReserveData("Available", "available");

        }

        private void addCustomerCenterButton_Click(object sender, RoutedEventArgs e)
        {
            CustomEventCenter cn = new CustomEventCenter();
            cn.startTimeTextBox.Text = EventCalculation.eventStartTime;
            this.Close();
            cn.ShowDialog();
        }

        private void skipButton_Click(object sender, RoutedEventArgs e)
        {

            EventCostCalculation EC = new EventCostCalculation();
            EC.photographyCostBox.Text = Convert.ToString(EventCalculation.photographyCost);
            EC.decorationCostBox.Text = Convert.ToString(EventCalculation.decorationCost);
            EC.CenterCostBox.Text = Convert.ToString(EventCalculation.totalcenterCost);
            EC.withoutVatBox.Text = EventCalculation.CalculationWithoutVat(EventCalculation.photographyCost, EventCalculation.decorationCost, EventCalculation.totalcenterCost);
            this.Close();
            EC.ShowDialog();
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            CenterService c = new CenterService();
            EventCalculation.totalcenterCost = c.SearchCenterCost(SearchCenterId);
            EventCalculation.centerId = SearchCenterId;
            EventCostCalculation EC = new EventCostCalculation();
            EC.photographyCostBox.Text = Convert.ToString(EventCalculation.photographyCost);
            EC.decorationCostBox.Text = Convert.ToString(EventCalculation.decorationCost);
            EC.CenterCostBox.Text = Convert.ToString(EventCalculation.totalcenterCost);
            EC.withoutVatBox.Text = EventCalculation.CalculationWithoutVat(EventCalculation.photographyCost,EventCalculation.decorationCost,EventCalculation.totalcenterCost);
            this.Close();
            EC.ShowDialog();
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

        private void centerInfoDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            CenterModel p = (CenterModel)e.AddedItems[0];
            SearchCenterId = p.CenterId;
            SearchCenterName = p.CenterName;
            
        }

        private void addCenterButton_Click(object sender, RoutedEventArgs e)
        {
            CenterService cs = new CenterService();
            addedCenterDataGrid.ItemsSource = cs.SearchDataTable(SearchCenterId, SearchCenterName);
        }
        private void removeCenterButton_Click(object sender, RoutedEventArgs e)
        {
            SearchCenterId = "";
            CenterService cs = new CenterService();
            addedCenterDataGrid.ItemsSource = cs.ReserveData("nonon", "nonono");
        }
    }
}
