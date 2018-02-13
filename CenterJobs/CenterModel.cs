using System;

namespace CenterJobs
{
    public class CenterModel
    {
        public static int count = 0;
        private string centerId;
        public static string centersId;
        private string centerName;
        private string centerCapacity;
        private string centerLocation;
        private string centerCost;
        private string centerStatus;
        private string foodCatering;

        public static string id()
        {
            string Year = Convert.ToString(System.DateTime.Now.Year);
            centersId =System.DateTime.Now.Minute+System.DateTime.Now.Hour+""+ System.DateTime.Now.Day+"-"+System.DateTime.Now.Month+"C" + "-"+Year[2]+Year[3];
            return centersId;
        }

        public CenterModel() { }

        public CenterModel(string centerId, string centerName, string centerCapacity, string centerLocation, string centerCost, string foodCatering,string centerStatus)
        {
           this.centerId = centerId;
            this.centerName = centerName;
            this.centerCapacity = centerCapacity;
            this.centerLocation = centerLocation;
            this.centerCost = centerCost;
            this.foodCatering = foodCatering;
            this.centerStatus = centerStatus;
           

        }


        public CenterModel(String centerId, string centerName, string centerCapacity, string centerLocation, string centerCost, string foodCatering)
        {
            this.centerId = centerId;
            this.centerName = centerName;
            this.centerCapacity = centerCapacity;
            this.centerLocation = centerLocation;
            this.centerCost = centerCost;
            this.foodCatering = foodCatering;

        }
        public string CenterId
        {
            get
            {
                return centerId;
            }
        }
        public string CenterName
        {
            get
            {
                return centerName;
            }
            set
            {
                centerName = value;
            }
        }
        public string CenterCapacity
        {
            get
            {
                return centerCapacity;
            }
            set
            {
                centerCapacity = value;
            }
        }
        public string CenterLocation
        {
            get
            {
                return centerLocation;
            }
            set
            {
                centerLocation = value;
            }
        }
        public string CenterCost
        {
            get
            {
                return centerCost;
            }
            set
            {
                centerCost = value;
            }
        }
        public string CenterStatus
        {
            get
            {
                return centerStatus;
            }
            set
            {
                centerStatus = value;
            }
        }
        public string FoodCatering
        {
            get
            {
                return foodCatering;
            }
            set
            {
                foodCatering = value;
            }
        }
    }
}
