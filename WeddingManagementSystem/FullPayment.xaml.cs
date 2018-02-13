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

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for FullPayment.xaml
    /// </summary>
    public partial class FullPayment : Window
    {
        public FullPayment()
        {
            InitializeComponent();

        }

        private void addVatDiscountButton_Click_1(object sender, RoutedEventArgs e)
        {
            
            EventCalculation.givenMoney = GivenMoneyBox.Text;
            EventCalculation.returnMoney = ReturnMoneyBox.Text;
            string moneyReturn= EventCalculation.returnMoneyCalculation(Convert.ToInt32(GivenMoneyBox.Text), Convert.ToInt32(RemainingMoneyBox.Text));
            if(moneyReturn!=null)
            {
                ReturnMoneyBox.Text = moneyReturn;
            }
            else
            {
                MessageBox.Show("Given Money Is Short");
            }
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            FullPaymentInvoice fullInvoice = new FullPaymentInvoice();
            fullInvoice.eventIdBox.Text = EventIdBlockText.Text;
            fullInvoice.GienMoneyBox.Text = GivenMoneyBox.Text;
            fullInvoice.retunMoneyBox.Text = EventCalculation.returnMoney;
            fullInvoice.paymentDateBox.Text = EventCalculation.getPaymentDate();
            fullInvoice.ShowDialog();
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            EventCalculation.returnMoney = "";
            EventCalculation.givenMoney = "";
            EventCalculation.returnMoney = "";
            this.Close();
        }
    }
}
