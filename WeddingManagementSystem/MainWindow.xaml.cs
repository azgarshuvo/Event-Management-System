using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Memberservices;
using MemberList;
using System.Data.SqlClient;
using CenterJobs;
using EventList;
using System.Collections.Generic;

namespace WeddingManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IDisposable
    {
        public MainWindow()
        {
            InitializeComponent();
            EventService es = new EventService();
            EventDataGrid.ItemsSource = es.LoadData();
        }
        public void Dispose() { }
        private void MembersButton_Click(object sender, RoutedEventArgs e)
        {
            SoftwareInfoButton.Background = Brushes.OliveDrab;
            HomeGrid.Visibility = System.Windows.Visibility.Collapsed;
            MyProfileViewGrid.Visibility = System.Windows.Visibility.Collapsed;
            MemberGrid.Visibility = System.Windows.Visibility.Visible;
            PackageGrid.Visibility = System.Windows.Visibility.Collapsed;
            MembersButton.Background = Brushes.Green;
            HomeButton.Background = Brushes.OliveDrab;
            PackagesButton.Background = Brushes.OliveDrab;
            DecorationButton.Background = Brushes.OliveDrab;
            DecorationrGrid.Visibility = System.Windows.Visibility.Collapsed;
            CenterGrid.Visibility = System.Windows.Visibility.Collapsed;
            SoftwareInfoGrid.Visibility = System.Windows.Visibility.Collapsed;
            MemberServices sr = new MemberServices();
            MembersListGrid.ItemsSource = sr.LoadData();
            MemberIdTextBox.Text = "";
            MemberNameTextBox.Text = "";
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = System.Windows.Visibility.Visible;
            MemberGrid.Visibility = System.Windows.Visibility.Collapsed;
            PackageGrid.Visibility = System.Windows.Visibility.Collapsed;
            MyProfileViewGrid.Visibility = System.Windows.Visibility.Collapsed;
            SoftwareInfoGrid.Visibility = System.Windows.Visibility.Collapsed;
            MembersButton.Background = Brushes.OliveDrab;
            HomeButton.Background = Brushes.Green;
            PackagesButton.Background = Brushes.OliveDrab;
            CenterButton.Background = Brushes.OliveDrab;
            CenterGrid.Visibility = System.Windows.Visibility.Collapsed;
            DecorationButton.Background = Brushes.OliveDrab;
            DecorationrGrid.Visibility = System.Windows.Visibility.Collapsed;
            SoftwareInfoButton.Background = Brushes.OliveDrab;
            EventList.EventService service = new EventList.EventService();
            EventDataGrid.ItemsSource = service.LoadData();



        }

        private void PackagesButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = System.Windows.Visibility.Collapsed;
            MemberGrid.Visibility = System.Windows.Visibility.Collapsed;
            PackageGrid.Visibility = System.Windows.Visibility.Visible;
            MyProfileViewGrid.Visibility = System.Windows.Visibility.Collapsed;
            SoftwareInfoGrid.Visibility = System.Windows.Visibility.Collapsed;
            MembersButton.Background = Brushes.OliveDrab;
            HomeButton.Background = Brushes.OliveDrab;
            PackagesButton.Background = Brushes.Green;
            CenterButton.Background = Brushes.OliveDrab;
            CenterGrid.Visibility = System.Windows.Visibility.Collapsed;
            DecorationButton.Background = Brushes.OliveDrab;
            DecorationrGrid.Visibility = System.Windows.Visibility.Collapsed;
            SoftwareInfoButton.Background = Brushes.OliveDrab;
        }

        private void AllPackageButton_Click(object sender, RoutedEventArgs e)
        {
            NewPackageButton.Background = Brushes.OliveDrab;
            CreateNewPackageButton.Background = Brushes.OliveDrab;
            AllPackageButton.Background = Brushes.Green;
            AllPackagesGrid.Visibility = System.Windows.Visibility.Visible;
            NewPackagesGrid.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void NewPackageButton_Click(object sender, RoutedEventArgs e)
        {
            NewPackageButton.Background = Brushes.Green;
            CreateNewPackageButton.Background = Brushes.OliveDrab;
            AllPackageButton.Background = Brushes.OliveDrab;
            AllPackagesGrid.Visibility = System.Windows.Visibility.Collapsed;
            NewPackagesGrid.Visibility = System.Windows.Visibility.Visible;
        }

        private void ReserveCenterButton_Click(object sender, RoutedEventArgs e)
        {
            AllCenterButton.Background = Brushes.OliveDrab;
            ReserveCenterButton.Background = Brushes.Green;
            AllCenterGrid.Visibility = System.Windows.Visibility.Visible;

            CenterService sr = new CenterService();
            centerDataGrid.ItemsSource = sr.ReserveData("Available", "available");
        }

        private void AllCenterButton_Click(object sender, RoutedEventArgs e)
        {
            AllCenterButton.Background = Brushes.Green;
            ReserveCenterButton.Background = Brushes.OliveDrab;
            AllCenterGrid.Visibility = System.Windows.Visibility.Visible;

            CenterService sr = new CenterService();
            centerDataGrid.ItemsSource = sr.LoadData();

        }

        private void CenterButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = System.Windows.Visibility.Collapsed;
            MemberGrid.Visibility = System.Windows.Visibility.Collapsed;
            PackageGrid.Visibility = System.Windows.Visibility.Collapsed;
            SoftwareInfoGrid.Visibility = System.Windows.Visibility.Collapsed;
            CenterGrid.Visibility = System.Windows.Visibility.Visible;
            SoftwareInfoButton.Background = Brushes.OliveDrab;
            DecorationButton.Background = Brushes.OliveDrab;
            DecorationrGrid.Visibility = System.Windows.Visibility.Collapsed;
            MyProfileViewGrid.Visibility = System.Windows.Visibility.Collapsed;
            MembersButton.Background = Brushes.OliveDrab;
            HomeButton.Background = Brushes.OliveDrab;
            PackagesButton.Background = Brushes.OliveDrab;
            CenterButton.Background = Brushes.Green;
            CenterService sr = new CenterService();
            centerDataGrid.ItemsSource = sr.LoadData();
        }

        private void DecorationButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = System.Windows.Visibility.Collapsed;
            MemberGrid.Visibility = System.Windows.Visibility.Collapsed;
            PackageGrid.Visibility = System.Windows.Visibility.Collapsed;
            CenterGrid.Visibility = System.Windows.Visibility.Collapsed;
            MyProfileViewGrid.Visibility = System.Windows.Visibility.Collapsed;
            MembersButton.Background = Brushes.OliveDrab;
            HomeButton.Background = Brushes.OliveDrab;
            PackagesButton.Background = Brushes.OliveDrab;
            CenterButton.Background = Brushes.OliveDrab;
            SoftwareInfoButton.Background = Brushes.OliveDrab;
            DecorationButton.Background = Brushes.Green;
            SoftwareInfoGrid.Visibility = System.Windows.Visibility.Collapsed;
            DecorationrGrid.Visibility = System.Windows.Visibility.Visible;
            Decoration.DecorationService sr = new Decoration.DecorationService();
            DecorationDataGrid.ItemsSource = sr.StageItemData("Stage", "stage");
            DecorationNameTextBox.Text = "";
            DecorationStatusTextBox.Text = "";
            DecorationCostTextBox.Text = "";
        }

        private void SoftwareInfoButton_Click(object sender, RoutedEventArgs e)
        {
            MembersButton.Background = Brushes.OliveDrab;
            HomeButton.Background = Brushes.OliveDrab;
            PackagesButton.Background = Brushes.OliveDrab;
            CenterButton.Background = Brushes.OliveDrab;
            DecorationButton.Background = Brushes.OliveDrab;
            DecorationrGrid.Visibility = System.Windows.Visibility.Collapsed;
            CenterGrid.Visibility = System.Windows.Visibility.Collapsed;
            PackageGrid.Visibility = System.Windows.Visibility.Collapsed;
            HomeGrid.Visibility = System.Windows.Visibility.Collapsed;
            MyProfileViewGrid.Visibility = System.Windows.Visibility.Collapsed;
            SoftwareInfoGrid.Visibility = System.Windows.Visibility.Visible;
            SoftwareInfoButton.Background = Brushes.Green;
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = System.Windows.Visibility.Collapsed;
            MyProfileViewGrid.Visibility = System.Windows.Visibility.Visible;
            // LoginPage log = new LoginPage();
            string id = LoginPage.userId;
            MemberServices ms = new MemberServices();
            
           
            ms.LoadProfile(id);
            EmployeeId.Text = id;
            EmployeeName.Text = ProfileMember.memberName;
            EmployeeDateOfBirth.Text = ProfileMember.dateOfBirth;
            EmployeeAddress.Text = ProfileMember.address;
            EmployeeConatactNumber.Text = ProfileMember.contactNumber;
            EmployeeEmail.Text = ProfileMember.email;
            EmployeeJoinDate.Text = ProfileMember.joinDate;
            EmployeePosition.Text = ProfileMember.memberPosition;
            EmployeeSalary.Text = ProfileMember.salary;
        }

        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeMyPassword changepassword = new ChangeMyPassword();
            changepassword.Show();
        }

        private void AddMemberButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewMember addmember = new AddNewMember();
            addmember.Show();
            MemberIdTextBox.Text = "";
            MemberNameTextBox.Text = "";
        }


        private void AllMemberButton_Click(object sender, RoutedEventArgs e)
        {
            MemberServices sr = new MemberServices();
            MembersListGrid.ItemsSource = sr.LoadData();
            MemberIdTextBox.Text = "";
            MemberNameTextBox.Text = "";
        }

        private void MembersListGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Changed");
            if (e.AddedItems.Count > 0)
            {
                Members p = (Members)e.AddedItems[0];
                MemberIdTextBox.Text = p.MemberId;
                MemberNameTextBox.Text = p.MemberName;

            }

        }

        private void MemberSearchButton_Click(object sender, RoutedEventArgs e)
        {
            MemberServices sr = new MemberServices();
            MembersListGrid.ItemsSource = sr.SearchData(MemberIdTextBox.Text, MemberNameTextBox.Text);
        }

        private void PhotographyMemberButton_Click(object sender, RoutedEventArgs e)
        {
            MemberServices sr = new MemberServices();
            MembersListGrid.ItemsSource = sr.PhotographerData("Photographer", "photographer");
            MemberIdTextBox.Text = "";
            MemberNameTextBox.Text = "";
        }

        private void ManagerMemberButton_Click(object sender, RoutedEventArgs e)
        {
            MemberServices sr = new MemberServices();
            MembersListGrid.ItemsSource = sr.ManagerData("Manager", "manager");
            MemberIdTextBox.Text = "";
            MemberNameTextBox.Text = "";
        }

        private void StaffMemberButton_Click(object sender, RoutedEventArgs e)
        {
            MemberServices sr = new MemberServices();
            MembersListGrid.ItemsSource = sr.StaffData("Staff", "staff");
            MemberIdTextBox.Text = "";
            MemberNameTextBox.Text = "";
        }

        private void MemberRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            MemberServices sr = new MemberServices();
            int i = sr.DeleteMember(MemberIdTextBox.Text, MemberNameTextBox.Text);
            MembersListGrid.ItemsSource = sr.LoadData();
            MemberIdTextBox.Text = "";
            MemberNameTextBox.Text = "";
        }

        private void MemberUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            string id = MemberIdTextBox.Text;
            string name = MemberNameTextBox.Text;
            //MessageBox.Show(id);
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();



            UpdateMember updateMember = new UpdateMember();
            //MemberServices sr = new MemberServices();
            //  SqlCommand cmd = new SqlCommand(sr.getById(id));
            //  SqlDataReader reader = cmd.ExecuteReader();
            // if (reader.HasRows)
            // {
            // if (reader.GetString(0) == id)
            //  {
            MemberServices memberservices = new MemberServices();
            Members members = new Members();
            memberservices.SetForUpdate(id);
            // MessageBox.Show(id);


            updateMember.UpdatenameTextBoxa.Text = members.MemberName;
            updateMember.UpdatepositionTextBoxa.Text = members.MemberPosition;
            updateMember.UpdatedateOfBirthTextBoxa.Text = members.DateOfBirth;
            updateMember.UpdatejoinDateTextBoxa.Text = members.JoinDate;
            updateMember.UpdatecontactNoTextBoxa.Text = members.ContactNumber;
            updateMember.UpdateemailTextBoxa.Text = members.Email;
            updateMember.UpdateaddressTextBoxa.Text = members.Address;
            updateMember.UpdatesalaryTextBoxa.Text = members.Salary;
            updateMember.Show();
        }

        private void AddNewCenterButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewCenter addNewCenter = new AddNewCenter();
            addNewCenter.ShowDialog();
        }

        private void AddNewDecorationButton_Click(object sender, RoutedEventArgs e)
        {
            AddDecorationForm ad = new AddDecorationForm();
            ad.ShowDialog();

        }

        private void DecorationUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Decoration.DecorationService update = new Decoration.DecorationService();
            int i = update.UpdateDecoration(DecorationNameTextBox.Text, DecorationStatusTextBox.Text, DecorationCostTextBox.Text);
            if (i == 1)
            {
                //MessageBox.Show("   Successfully Updated   ")
                DecorationDataGrid.ItemsSource = update.StageItemData(DecorationNameTextBox.Text, DecorationNameTextBox.Text);
                DecorationNameTextBox.Text = "";
                DecorationStatusTextBox.Text = "";
                DecorationCostTextBox.Text = "";

            }
        }

        private void DecorationUpgradeGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Changed");
            if (e.AddedItems.Count > 0)
            {
                Decoration.DecorationList p = (Decoration.DecorationList)e.AddedItems[0];
                DecorationNameTextBox.Text = p.DecorationItem;
                DecorationStatusTextBox.Text = p.DecorationType;
                DecorationCostTextBox.Text = p.DecorationCost;
            }

        }

        private void StageButton_Click(object sender, RoutedEventArgs e)
        {
            Decoration.DecorationService sr = new Decoration.DecorationService();
            DecorationDataGrid.ItemsSource = sr.StageItemData("Stage", "stage");
            DecorationNameTextBox.Text = "";
            DecorationStatusTextBox.Text = "";
            DecorationCostTextBox.Text = "";
        }

        private void HomeLightButton_Click(object sender, RoutedEventArgs e)
        {
            Decoration.DecorationService sr = new Decoration.DecorationService();
            DecorationDataGrid.ItemsSource = sr.StageItemData("HomeLight", "homelight");
            DecorationNameTextBox.Text = "";
            DecorationStatusTextBox.Text = "";
            DecorationCostTextBox.Text = "";
        }

        private void GateButton_Click(object sender, RoutedEventArgs e)
        {
            Decoration.DecorationService sr = new Decoration.DecorationService();
            DecorationDataGrid.ItemsSource = sr.StageItemData("Gate", "gate");
            DecorationNameTextBox.Text = "";
            DecorationStatusTextBox.Text = "";
            DecorationCostTextBox.Text = "";
        }

        private void StreetLightButton_Click(object sender, RoutedEventArgs e)
        {
            Decoration.DecorationService sr = new Decoration.DecorationService();
            DecorationDataGrid.ItemsSource = sr.StageItemData("StreetLight", "streetlight");
            DecorationNameTextBox.Text = "";
            DecorationStatusTextBox.Text = "";
            DecorationCostTextBox.Text = "";
        }

        private void PalanquinButton_Click(object sender, RoutedEventArgs e)
        {
            Decoration.DecorationService sr = new Decoration.DecorationService();
            DecorationDataGrid.ItemsSource = sr.StageItemData("Palanquin", "palanquin");
            DecorationNameTextBox.Text = "";
            DecorationStatusTextBox.Text = "";
            DecorationCostTextBox.Text = "";
        }

        private void DecorationRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Decoration.DecorationService DL = new Decoration.DecorationService();
            int i = DL.DeleteDecoration(DecorationNameTextBox.Text, DecorationStatusTextBox.Text);
            DecorationDataGrid.ItemsSource = DL.StageItemData(DecorationNameTextBox.Text, DecorationNameTextBox.Text);
            DecorationNameTextBox.Text = "";
            DecorationStatusTextBox.Text = "";
            DecorationCostTextBox.Text = "";
        }

        private void CreateEventButton_Click(object sender, RoutedEventArgs e)
        {
            CreateNewEvent cn = new CreateNewEvent();
            cn.ShowDialog();
        }

        private void centerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                CenterModel p = (CenterModel)e.AddedItems[0];
                CenterIdTextBox.Text = p.CenterId;
                CenterNameTextBox.Text = p.CenterName;
                CenterCapacityTextBox.Text = p.CenterCapacity;
                CenterCostTextBox.Text = p.CenterCost;
                CenterFoodTextBox.Text = p.FoodCatering;
                CenterLocationTextBox.Text = p.CenterLocation;


            }
        }

        private void CenterSearchButton_Click(object sender, RoutedEventArgs e)
        {
            string id = Convert.ToString(CenterIdTextBox.Text);
            string name = Convert.ToString( CenterNameTextBox.Text);
            //string loc = Convert.ToString(CenterLocationTextBox.Text);


            CenterService sr = new CenterService();
            centerDataGrid.ItemsSource = sr.SearchData(id, name );
           
        }

        private void CenterRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            string id = Convert.ToString(CenterIdTextBox.Text);
            string name = Convert.ToString(CenterNameTextBox.Text);
            CenterService cs = new CenterService();
            cs.DeleteCenter(id, name);
            centerDataGrid.ItemsSource = cs.LoadData();
            CenterIdTextBox.Text = "";
            CenterNameTextBox.Text = "";
            CenterCapacityTextBox.Text = "";
            CenterCostTextBox.Text = "";
            CenterFoodTextBox.Text = "";
            CenterLocationTextBox.Text = "";
        }

        private void CenterUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //string name = Convert.ToString(CenterNameTextBox.Text);
            //string capacity= Convert.ToString(CenterCapacityTextBox.Text);
           // string location= Convert.ToString(CenterLocationTextBox.Text);
            //string cost= Convert.ToString(CenterCostTextBox.Text);
           // string food= Convert.ToString(CenterFoodTextBox.Text);
            CenterService cs = new CenterService();
            cs.UpdateCenter(CenterNameTextBox.Text, CenterCapacityTextBox.Text, CenterLocationTextBox.Text, CenterCostTextBox.Text, CenterFoodTextBox.Text);
            centerDataGrid.ItemsSource = cs.LoadData();


        }

        private void EventDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


     
            //MessageBox.Show("Changed");
            if (e.AddedItems.Count > 0)
            {
                EventList.EventsList p = (EventList.EventsList)e.AddedItems[0];
                EventIdTexBox.Text = p.EventId;
              

        }
    }

      

        private void DeleteEvent_Click_1(object sender, RoutedEventArgs e)
        {
            string id = Convert.ToString(EventIdTexBox.Text);
            EventService es = new EventService();
            es.RemoveEvent(id);
            EventDataGrid.ItemsSource=es.LoadData();
            EventIdTexBox.Text= "";

            
        }
        
        private void UpcomingViewButton_Click(object sender, RoutedEventArgs e)
        {
            List<EventsList> eventList = new List<EventsList>();
            DateTime from=FromDate.SelectedDate.Value;
            DateTime to=ToDate.SelectedDate.Value;
            EventService es = new EventService();
            es.getEventList(from,to);
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand(es.getEventList(from, to), connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    eventList.Add( new EventsList(reader.GetString(0), reader.GetString(1), reader.GetString(2), Convert.ToDouble(reader.GetString(3)), Convert.ToDouble(reader.GetString(4)), Convert.ToDouble(reader.GetString(5)), Convert.ToDouble(reader.GetString(6)), Convert.ToDouble(reader.GetString(7)), Convert.ToDouble(reader.GetString(8)), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16)));
                }
            }
            EventDataGrid.ItemsSource = eventList;
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            EventService es = new EventService();
            string id = Convert.ToString(EventIdTexBox.Text);
            
            if (es.SearchStatus(id).Equals("Paid"))
            {
                MessageBox.Show("  Already Paid  ");
            }
            else
            {
                EventCalculation.temporaryId = id;
                String ReminingPayment = es.SearchRemainingMoney(id);
                String AdvancePayment = es.SearchAdvanceMoney(id);
                FullPayment full = new FullPayment();
                full.EventIdBlockText.Text = id;
                full.AdvanceMoneyBox.Text = AdvancePayment;
                full.RemainingMoneyBox.Text = ReminingPayment;
                full.ShowDialog();
                EventIdTexBox.Text = "";
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            this.Close();
            lp.Show();
           
        }
    }
}
    

    
