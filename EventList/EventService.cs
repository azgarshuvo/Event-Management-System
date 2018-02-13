using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CenterJobs;

namespace EventList
{
    public class EventService
    {
        public static string RemainingMoney;
        public static string EStatus;
        public string CreateEventId()
        {
            string year = Convert.ToString(System.DateTime.Now.Year);
            return (System.DateTime.Now.Month + "" + System.DateTime.Now.Day + "." + year[2] + year[3] + "." + System.DateTime.Now.Hour + "." + System.DateTime.Now.Minute + "E");
        }
        public int AddEvent(EventsList EL)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-pc; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            string query = "INSERT INTO EventList(EventId,EventDate,StartTime,PhotographyCost,DecorationCost,CenterCost,Vat,Discount,TotalCost,AdvancePayment,Remaining,CustomerName,CustomerContact, CustomerEmail,CustomerAddress,PackageId,PackageCost,EDate,PaymentStatus) VALUES('" + EL.EventId + "', '" + EL.EventDate + "', '" + EL.StartTime + "', '" + EL.PhotographyCost + "','" + EL.DecorationCost + "','" + EL.CenterCost + "','" + EL.Vat + "','" + EL.Discount + "','" + EL.TotalCost + "','" + EL.AdvancePayment + "','" + EL.Remaining + "','" + EL.CustomerName + "','" + EL.CustomerContactNo + "','" + EL.CustomerEmail + "','" + EL.CustomerAddress + "','" + EL.PackageId + "','"+ EL.PackageCost + "','" + EventCalculation.date + "','"+ EventCalculation.paymentStatus+"')";
            SqlCommand cmd = new SqlCommand(query, connection);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public List<EventsList> LoadData()
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT EventId,EventDate,StartTime,PhotographyCost,DecorationCost,CenterCost,Vat,Discount,TotalCost,AdvancePayment,Remaining,CustomerName,CustomerContact,CustomerEmail,CustomerAddress,PackageId,PackageCost,PaymentStatus FROM EventList", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<EventsList> EventList = new List<EventsList>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EventList.Add(new EventsList(reader.GetString(0), reader.GetString(1), reader.GetString(2), Convert.ToDouble(reader.GetString(3)), Convert.ToDouble(reader.GetString(4)), Convert.ToDouble(reader.GetString(5)), Convert.ToDouble(reader.GetString(6)), Convert.ToDouble(reader.GetString(7)),  Convert.ToDouble(reader.GetString(8)), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16),reader.GetString(17)));
                }
            }
            return EventList;
        }

        public int RemoveEvent(string searchId)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand del = new SqlCommand("DELETE FROM EventList WHERE EventId LIKE '" + searchId + "'", connection);
            int i = del.ExecuteNonQuery();
            connection.Close();
            CenterService cs = new CenterService();
            cs.UpdateCenterStatus(searchId, "Available");
            return i;
        }
        public string getEventList(DateTime fromDate, DateTime toDate)
        {
            String getEvent = " ";

            getEvent += "Select *from EventList  Where EDate between '"+fromDate+"' AND '"+toDate+"'";
            return getEvent;
        }
        public String SearchRemainingMoney(String id)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT EventId,EventDate,StartTime,PhotographyCost,DecorationCost,CenterCost,Vat,Discount,TotalCost,AdvancePayment,Remaining,CustomerName,CustomerContact,CustomerEmail,CustomerAddress,PackageId,PackageCost,PaymentStatus FROM EventList WHERE EventId Like '"+id+"'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    RemainingMoney = reader.GetString(10);
                }
            }
            connection.Close();
            return RemainingMoney;
        }
    
        public String SearchAdvanceMoney(String id)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT EventId,EventDate,StartTime,PhotographyCost,DecorationCost,CenterCost,Vat,Discount,TotalCost,AdvancePayment,Remaining,CustomerName,CustomerContact,CustomerEmail,CustomerAddress,PackageId,PackageCost,PaymentStatus FROM EventList WHERE EventId Like '" + id + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    RemainingMoney = reader.GetString(9);
                }
            }
            connection.Close();
            return RemainingMoney;
        }
        public void UpdateEventList(string eventId,string Given, string returnMoney)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE EventList SET PaymentStatus ='Paid', GivenMoney='" + Given + "', ReturnMoney= '" + returnMoney + "' WHERE EventId Like '"+eventId+"'", connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();

        }
        public string SearchStatus(string id)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT EventId,EventDate,StartTime,PhotographyCost,DecorationCost,CenterCost,Vat,Discount,TotalCost,AdvancePayment,Remaining,CustomerName,CustomerContact,CustomerEmail,CustomerAddress,PackageId,PackageCost,PaymentStatus FROM EventList WHERE EventId Like '" + id + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EStatus = reader.GetString(17);
                }
            }
            connection.Close();
            return EStatus;
        }
    }
}
