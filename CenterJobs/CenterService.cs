using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CenterJobs
{
    public class CenterService
    {
        public double centerCost;
        public List<CenterModel>LoadData()
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT CenterId, CenterName,capacity,location,cost,FoodCatering, Status FROM CenterList", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CenterModel> centerList = new List<CenterModel>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    centerList.Add(new CenterModel(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5),reader.GetString(6)));
                }
            }
            connection.Close();
            return centerList;
        }

        public int AddNewCenter(CenterModel Emp)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-pc; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            string query = "INSERT INTO CenterList(CenterId, CenterName, capacity, location, cost, FoodCatering, Status ) VALUES('" + Emp.CenterId + "', '" + Emp.CenterName + "', '" + Emp.CenterCapacity + "', '" + Emp.CenterLocation + "','" + Emp.CenterCost + "','" + Emp.FoodCatering + "','" + "Available" + "')";
            SqlCommand cmd = new SqlCommand(query, connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;

        }

        public List<CenterModel> ReserveData(string String1, string String2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT CenterId, CenterName,capacity,location,cost,FoodCatering,Status FROM CenterList WHERE (Status LIKE '"+"%"+ String1 +"%"+ "' OR Status LIKE '" + "%" + String2 + "%" + "')", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CenterModel> personList = new List<CenterModel>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    personList.Add(new CenterModel(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5),reader.GetString(6)));
                }
            }
            connection.Close();
            return personList;
        }

             public double SearchCenterCost(string centerId)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT CenterId, CenterName, capacity, location, cost, FoodCatering, Status FROM CenterList WHERE (CenterId LIKE '" + centerId + "')", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    centerCost = Convert.ToDouble(reader.GetString(4));
                }
            }
            connection.Close();
            return centerCost;
        }

        public List<CenterModel> SearchData(string Search1, string Search2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT  CenterId,CenterName,capacity,location,cost,FoodCatering, Status FROM CenterList WHERE (CenterId LIKE'" + Search1 + "') OR (CenterName Like '" + "%" + Search2 + "%" + "')", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CenterModel> CenterList = new List<CenterModel>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CenterList.Add(new CenterModel(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5),reader.GetString(6)));
                }
            }
            connection.Close();
            return CenterList;
        }

        public int DeleteCenter(string String1, string String2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM CenterList WHERE (CenterId LIKE'" + String1 + "') AND (CenterName Like '" + String2 + "')", connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;
        }

        public void UpdateCenter(string cnName, string cnCapacity, string cnLocation, string cnCost, string fdCatering)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CenterList SET capacity ='" + cnCapacity + "', location='" + cnLocation + "', cost= '" + cnCost + "', FoodCatering= '" + fdCatering + "'  WHERE CenterName= '" + cnName + "'", connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();
           
        }
        public void UpdateCenterStatus(string Id, string centerStatus)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CenterList SET Status ='" + centerStatus + "' WHERE Status LIKE '" + Id + "'", connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void BookCenter(string centerStatus, string Id)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CenterList SET Status ='"+ centerStatus + "'WHERE CenterId LIKE '" + Id + "'", connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();

        }

        public List<CenterModel> SearchDataTable(string Search1, string Search2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT  CenterId,CenterName,capacity,location,cost,FoodCatering, Status FROM CenterList WHERE (CenterId LIKE'" + Search1 + "') AND (CenterName Like '" + "%" + Search2 + "%" + "')", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CenterModel> personList = new List<CenterModel>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    personList.Add(new CenterModel(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5),reader.GetString(6)));
                }
            }
            connection.Close();
            return personList;
        }

    }
}
