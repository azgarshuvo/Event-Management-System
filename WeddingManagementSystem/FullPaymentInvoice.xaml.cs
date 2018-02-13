using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EventList;
using CenterJobs;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for FullPaymentInvoice.xaml
    /// </summary>
    public partial class FullPaymentInvoice : Window
    {
        public FullPaymentInvoice()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog prnt = new System.Windows.Controls.PrintDialog();
            if (prnt.ShowDialog() == true)
            {
                prnt.PrintVisual(FullPaymentInvoiceGrid, "Printing Grid");
            }
            EventService Es = new EventService();
            Es.UpdateEventList(eventIdBox.Text, GienMoneyBox.Text, retunMoneyBox.Text);
            CenterService cs = new CenterService();
            cs.UpdateCenterStatus(eventIdBox.Text, "Available");
            EventCalculation.returnMoney = "";
            EventCalculation.givenMoney = "";
            EventCalculation.returnMoney = "";
            EventCalculation.centerId = "";
            EventCalculation.eventId = "";
            this.Close();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            EventCalculation.returnMoney = "";
            EventCalculation.givenMoney = "";
            EventCalculation.returnMoney = "";
            this.Close();
        }
    }
}
