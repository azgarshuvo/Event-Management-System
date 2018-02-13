using System;

namespace Packages
{
    class Packages
    {
        
        private readonly string package_Id;
        private string package_Name;
        private string package_Type;
        private string photographer_1;
        private string photographer_2;
        private string photographer_3;
        private string duration_In_Hour;
        private string duration_In_Day;
        private string printed_Photos;
        private string decoration;
        private string center_Name;
        private string center_Location;
        private string center_Capacity;
        private string regular_Cost;
        private string package_Cost;
        private string money_Save;
        private string package_Status;


        public Packages() { }
        public Packages(string package_Name ="UNKNOWN", string package_Type = "UNKNOWN", string photographer_1 = " ", string photographer_2 = " ", string photographer_3 = "UNKNOWN", string duration_In_Hour = "UNKNOWN", string duration_In_Day = "UNKNOWN", string printed_Photos = "UNKNOWN", string decoration = "UNKNOWN", string center_Name = "UNKNOWN", string center_Location = "UNKNOWN", string center_Capacity = "UNKNOWN", string regular_Cost = "UNKNOWN", string package_Cost = "UNKNOWN", string money_Save = "UNKNOWN")
        {
            if (Package_Type.Equals("GOLD"))
            {
                string date = Convert.ToString(System.DateTime.Now.Year);
                string s1 = Convert.ToString(date[2]);
                string s2 = Convert.ToString(date[3]); ;
                package_Id = s1 + s2 + "G";

            }
            if (Package_Type.Equals("SILVER"))
            {
                string date = Convert.ToString(System.DateTime.Now.Year);
                string s1 = Convert.ToString(date[2]);
                string s2 = Convert.ToString(date[3]); ;
                package_Id = s1 +s2 + "S";

            }
            if (Package_Type.Equals("PLATINUM"))
            {
                string date = Convert.ToString(System.DateTime.Now.Year);
                string s1 = Convert.ToString(date[2]);
                string s2 = Convert.ToString(date[3]); ;
                package_Id = s1 + s2 + "P";

            }
            if (Package_Type.Equals("REGULAR"))
            {
                string date = Convert.ToString(System.DateTime.Now.Year);
                string s1 = Convert.ToString(date[2]);
                string s2 = Convert.ToString(date[3]); ;
                package_Id = s1 + s2 + "R";

            }
            this.package_Name = package_Name;
            this.package_Type = package_Type;
            this.photographer_1 = photographer_1;
            this.photographer_2 = photographer_2;
            this.photographer_3 = photographer_3;
            this.duration_In_Hour = duration_In_Hour;
            this.duration_In_Day = duration_In_Day;
            this.printed_Photos = printed_Photos;
            this.decoration = decoration;
            this.center_Name = center_Name;
            this.center_Location = center_Location;
            this.center_Capacity = center_Capacity;
            this.regular_Cost = regular_Cost;
            this.package_Cost = package_Cost;
            this.money_Save = money_Save;
            package_Status = "Deactivated";

        }
      
        public string Package_Id
        {
            get
            {
                return Package_Id;
            }
        }
        public string Package_Name
        {
            get
            {
                return Package_Name;
            }

            set
            {
                Package_Name = value;
            }
        }

        public string Package_Type
        {
            get
            {
                return package_Type;
            }

            set
            {
                package_Type = value;
            }
        }

        public string Photographer_1
        {
            get
            {
                return photographer_1;
            }

            set
            {
                photographer_1 = value;
            }
        }

        public string Photographer_2
        {
            get
            {
                return photographer_2;
            }

            set
            {
                photographer_2 = value;
            }
        }

        public string Photographer_3
        {
            get
            {
                return photographer_3;
            }

            set
            {
                photographer_3 = value;
            }
        }

        public string Duration_In_Hour
        {
            get
            {
                return duration_In_Hour;
            }

            set
            {
                duration_In_Hour = value;
            }
        }

        public string Duration_In_Day
        {
            get
            {
                return duration_In_Day;
            }

            set
            {
                duration_In_Day = value;
            }
        }

        public string Printed_Photos
        {
            get
            {
                return printed_Photos;
            }

            set
            {
                printed_Photos = value;
            }
        }

        public string Decoration
        {
            get
            {
                return decoration;
            }

            set
            {
                decoration = value;
            }
        }

        public string Center_Name
        {
            get
            {
                return center_Name;
            }

            set
            {
                center_Name = value;
            }
        }

        public string Center_Location
        {
            get
            {
                return center_Location;
            }

            set
            {
                center_Location = value;
            }
        }

        public string Center_Capacity
        {
            get
            {
                return center_Capacity;
            }

            set
            {
                center_Capacity = value;
            }
        }

        public string Regular_Cost
        {
            get
            {
                return regular_Cost;
            }

            set
            {
                regular_Cost = value;
            }
        }

        public string Package_Cost
        {
            get
            {
                return package_Cost;
            }

            set
            {
                package_Cost = value;
            }
        }

        public string Money_Save
        {
            get
            {
                return money_Save;
            }

            set
            {
                money_Save = value;
            }
        }

        public string Package_Status
        {
            get
            {
                return package_Status;
            }

            set
            {
                package_Status = value;
            }
        }
    }
}
