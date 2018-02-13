using System;
using System.Windows;
using CenterJobs;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for AddNewCenter.xaml
    /// </summary>
    public partial class AddNewCenter : Window
    {
        public AddNewCenter()
        {
            InitializeComponent();
        }


        private void Add_Button_Click_1(object sender, RoutedEventArgs e)
        {

            string centerName = Convert.ToString(Center_Name_textBox.Text);
            string centerCapacity = Convert.ToString(Center_Capacity_textBox.Text);
            string centerLocation = Convert.ToString(Center_Location_textBox.Text);
            string centerCost = Convert.ToString(Center_Cost_textBox.Text);
            string centerCatering = Convert.ToString(Center_Catering_textBox.Text);
           

            CenterJobs.CenterModel newCenter = new CenterJobs.CenterModel(CenterModel.id(),centerName, centerCapacity, centerLocation, centerCost, centerCatering);
        
            CenterJobs.CenterService cs = new CenterJobs.CenterService();
            int i = cs.AddNewCenter(newCenter);
            
            MainWindow mw = new MainWindow();
            mw.centerDataGrid.ItemsSource = cs.LoadData();
            this.Close();

        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
