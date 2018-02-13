using System;
using System.Collections.Generic;
using MemberList;
using System.Data.SqlClient;







namespace Memberservices
{
    public class MemberServices
    {
       
            public int AddtoPhotographer(string searchId, string searchName, string searchContact, string searchEmail, string searchDemand)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-pc; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            string query = "INSERT INTO AddedPhotoGrapher(Id,Name,Email,ContactNumber,Salary) VALUES('" + searchId + "', '" + searchName + "', '" + searchContact + "', '" + searchEmail + "','" + searchDemand + "')";
            SqlCommand cmd = new SqlCommand(query, connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;
        }
            public int RemoveFromPhotographer(string searchId)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand del = new SqlCommand("DELETE FROM AddedPhotoGrapher WHERE Id LIKE '" + "%" + searchId + "%" + "'", connection);
            int i = del.ExecuteNonQuery();
            connection.Close();
            return i;
        }
        public int ClearTable()
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE AddedPhotographer", connection);
            int i = cmd.ExecuteNonQuery();
            
            connection.Close();
            return i;
        }
        public List<Members> SearchPhotogrpaherhData()
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id, Name,Email,ContactNumber,Salary FROM AddedPhotographer", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Members> SearchList = new List<Members>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SearchList.Add(new Members(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                }
            }
            return SearchList;
        }
        public List<Members> LoadData()
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT memberName, memberPosition,dateOfBirth,contactNumber,joinDate,email,address,salary FROM MembersList", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Members> personList = new List<Members>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    personList.Add(new Members(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }
            }
            return personList;
        }
        public int AddMembers(Members Emp)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-pc; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            string query = "INSERT INTO MembersList(memberId, memberName, memberPosition, dateOfBirth, contactNumber, joinDate, email, address, salary, available, password, securityQuestion ) VALUES('" + Emp.MemberId + "', '" + Emp.MemberName + "', '" + Emp.MemberPosition + "', '" + Emp.DateOfBirth + "','" + Emp.ContactNumber + "','" + Emp.JoinDate + "','" + Emp.Email + "','" + Emp.Address + "','" + Emp.Salary + "','" + Emp.Available + "','" + Emp.Password + "','" + Emp.SecurityQuestion + "')";
            SqlCommand cmd = new SqlCommand(query, connection);
            int i = cmd.ExecuteNonQuery();

            return i;

        }

        public List<Members> SearchData(string Search1, string Search2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT memberName, memberPosition,dateOfBirth,contactNumber,joinDate,email,address,salary FROM MembersList WHERE (memberId LIKE'" + Search1 + "') OR (memberName Like '" + "%" + Search2 + "%" + "')", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Members> personList = new List<Members>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    personList.Add(new Members(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }
            }
            return personList;
        }
        public List<Members> PhotographerData(string String1, string String2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT memberName, memberPosition,dateOfBirth,contactNumber,joinDate,email,address,salary FROM MembersList WHERE (memberPosition LIKE'" + String1 + "') OR (memberPosition Like '" + "%" + String2 + "%" + "')", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Members> personList = new List<Members>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    personList.Add(new Members(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }
            }
            return personList;
        }
        public List<Members> ManagerData(string String1, string String2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT memberName, memberPosition,dateOfBirth,contactNumber,joinDate,email,address,salary FROM MembersList WHERE (memberPosition LIKE'" + String1 + "') OR (memberPosition Like '" + "%" + String2 + "%" + "')", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Members> personList = new List<Members>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    personList.Add(new Members(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }
            }
            return personList;
        }
        public List<Members> StaffData(string String1, string String2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT memberName, memberPosition,dateOfBirth,contactNumber,joinDate,email,address,salary FROM MembersList WHERE (memberPosition LIKE'" + String1 + "') OR (memberPosition Like '" + "%" + String2 + "%" + "')", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Members> personList = new List<Members>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    personList.Add(new Members(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }
            }
            return personList;
        }
        public int DeleteMember(string String1, string String2)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM MembersList WHERE (memberId LIKE'" + String1 + "') AND (memberName Like '" + String2 + "')", connection);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public void SetForUpdate(string id)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT memberName, memberPosition,dateOfBirth,contactNumber,joinDate,email,address,salary FROM MembersList WHERE memberId ='" + id + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read()==true)
                {
                    Members member = new Members();
                    member.MemberName = reader.GetString(0);
                    member.MemberPosition = reader.GetString(1);
                    member.DateOfBirth = reader.GetString(2);
                    member.ContactNumber = reader.GetString(3);
                    member.JoinDate = reader.GetString(4);
                    member.Email = reader.GetString(5);
                    member.Address = reader.GetString(6);
                    member.Salary = reader.GetString(7);
                }

            }

        }
        public void UpdateMember(string memberName, string memberPosition, string dateOfBirth, string contactNumber, string joinDate, string email, string address, string salary)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE MembersList SET memberName ='" + memberName + "',memberPosition='" + memberPosition + "',dateOfBirth= '" + dateOfBirth + "', contactNumber= '" + contactNumber + "' , joinDate='" + joinDate + "',email='" + email + "',address ='" + address + "',salary='" + salary + "' WHERE memberName= '" + memberName + "')", connection);
            int i = cmd.ExecuteNonQuery();
        }
           
       public string getById(String Id)
        {
            
            String searchById = " ";
           
            searchById += "Select memberId,password from MembersList  Where memberId = '" + Id + "'";
            return searchById;
        }
        public void LoadProfile(String id)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT memberName, memberPosition,dateOfBirth,contactNumber,joinDate,email,address,salary FROM MembersList Where memberId ='"+id+"'", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                 
                    ProfileMember.memberName = reader.GetString(0);
                    ProfileMember.memberPosition = reader.GetString(1);
                    ProfileMember.dateOfBirth = reader.GetString(2);
                    ProfileMember.contactNumber = reader.GetString(3);
                    ProfileMember.joinDate = reader.GetString(4);
                    ProfileMember.email = reader.GetString(5);
                    ProfileMember.address = reader.GetString(6);
                    ProfileMember.salary = reader.GetString(7);

                }
            }


          
        }
        public int UpdatePassword(string old,string nw,string id)
        {
            SqlConnection connection = new SqlConnection("Server=Tanmoy-PC; Database=Wedding Management; User Id=sa; Password=1238628257");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE MembersList SET password ='"+nw+"' WHERE password='"+old+"' AND  memberId='"+id+"'", connection);
            int i = cmd.ExecuteNonQuery();
           
            return i;
        }

    }
}
     

    //}
//}
