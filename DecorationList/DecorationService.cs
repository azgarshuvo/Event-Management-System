using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Decoration
{
    public class DecorationService
    {
        public double cost;
        public List<DecorationList> DecorationLoadData()
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT item, type, cost FROM DecorationList", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<DecorationList> DecorList = new List<DecorationList>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DecorList.Add(new DecorationList(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                }
            }
            connection.Close();
            return DecorList;
        }
        public int AddDecorationItem(DecorationList Emp)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-pc; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            string query = "INSERT INTO DecorationList(item, type, cost ) VALUES('" + Emp.DecorationItem + "', '" + Emp.DecorationType + "', '" + Emp.DecorationCost + "')";
            SqlCommand cmd = new SqlCommand(query, connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;

        }
        public List<Decoration.DecorationList> StageItemData(string String1, string String2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT item,type,cost FROM DecorationList WHERE (item ='" + String1 + "') OR (item ='" + String2 +"')", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Decoration.DecorationList> stageList = new List<Decoration.DecorationList>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    stageList.Add(new Decoration.DecorationList(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                }
            }
            connection.Close();
            return stageList;
        }
        public List<Decoration.DecorationList> ComboBoxItemData(string String1, string String2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT type,cost FROM DecorationList WHERE (item ='" + String1 + "') OR (item ='" + String2 + "')", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Decoration.DecorationList> comboList = new List<Decoration.DecorationList>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboList.Add(new Decoration.DecorationList(reader.GetString(0), reader.GetString(1)));
                    
                }
            }
            connection.Close();
            return comboList;
        }
        public int DeleteDecoration(string String1, string String2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM DecorationList WHERE (item = '" + String1 + "') AND (type = '" + String2 + "')", connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;
        }
        public double SearchDecorationCost(string sitem,string stype)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT item ,type,cost FROM DecorationList WHERE (item LIKE '" + "%" + sitem + "%" + "') AND (type LIKE '" + "%" + stype+ "%" + "')", connection);
            SqlDataReader reader9 = cmd.ExecuteReader();
            if (reader9.HasRows)
            {
                while (reader9.Read())
                { 
                    cost = Convert.ToDouble(reader9.GetString(2));
            }
                
            }
            connection.Close();
            return cost;
        }
        public int UpdateDecoration(string item, string type, string cost)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE DecorationList SET type='" + type + "',cost='" + cost + "' WHERE  item Like '"+item+"'", connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return 1;
        }
    }
}
