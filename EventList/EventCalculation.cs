using System;
using Decoration;

namespace EventList
{
    public static class EventCalculation
    {
        public static DateTime date;
        public static string eventDate;
        public static string eventStartTime;
        public static string eventEndTime;
        public static string printedPhotos;
        public static string eachPhotoCost;
        public static double photographyCost;
        public static double decorationCost;
        public static string stage;
        public static string homelight;
        public static string homelightDuration;
        public static string streetlight;
        public static string streetlightDeuration;
        public static string gate;
        public static string planaquin;
        public static string centerName;
        public static string centerLoaction;
        public static double totalCostWithoutVat;
        public static double totalcenterCost;
        public static string eventDuration;
        public static double CostStage;
        public static double CostHomeLight;
        public static double CostStreetLight;
        public static double CostGate;
        public static double CostPlanaquin;
        public static double vat;
        public static double discount;
        public static double totalCostWithVat;
        public static string customerName;
        public static string customerContactNumber;
        public static string customerEmail;
        public static string customerAddress;
        public static string eventId;
        public static string advancePay;
        public static string remainingPay;
        public static string paymentStatus="Pending";
        public static string givenMoney;
        public static string returnMoney;
        public static string centerId;
        public static string temporaryId;

        public static string getPaymentDate()
        {
            string z= Convert.ToString(System.DateTime.Now);
            return z;
        }
        public static string getReturnMoney()
        {
            string y = Convert.ToString(returnMoney);
            return y;
        }

        public static void totalDecorationCost(string stage1,string homelight1,string homelightDuration1,string streetlight1,string streetlightDuration1,string gate1,string planaquin1)
        {
            DecorationService DS = new DecorationService();
            CostStage = DS.SearchDecorationCost("Stage",stage1);
            CostHomeLight =(Convert.ToDouble(homelightDuration1))*(DS.SearchDecorationCost("HomeLight",homelight1));
            CostStreetLight =(Convert.ToDouble(streetlightDuration1)) * (DS.SearchDecorationCost("StreetLight",streetlight1));
            CostGate = DS.SearchDecorationCost("Gate",gate1);
            CostPlanaquin = DS.SearchDecorationCost("Palanquin",planaquin1);
            decorationCost = CostGate + CostHomeLight + CostPlanaquin + CostStage + CostStreetLight ;
        }

        public static int Duration(double StartTime,double EndTime)
        {
            int TotalDuration = Convert.ToInt32(EndTime) - Convert.ToInt32(StartTime);
            eventDuration = Convert.ToString(TotalDuration);
            return TotalDuration;
        }
       public static string CalculationWithoutVat(double ph=0,double dc=0,double cc=0)
        {
            totalCostWithoutVat = ph + dc + cc;
            return Convert.ToString(totalCostWithoutVat);
        }
        public static string CalculationWithVat(string v,string d)
        {
            vat = Convert.ToDouble(v);
            discount = Convert.ToDouble(d);
            totalCostWithVat = Convert.ToInt32(((totalCostWithoutVat * (Convert.ToDouble(v) / 100))+totalCostWithoutVat) - (totalCostWithoutVat*(Convert.ToDouble(d)/100)));
            return Convert.ToString(totalCostWithVat);
        }
        public static string CalculateRemaining()
        {
           remainingPay= Convert.ToString(totalCostWithVat - Convert.ToInt32(advancePay));
            return remainingPay;
        }
        public static string getPhotographyCost()
        {
            return Convert.ToString(photographyCost);
        }
        public static string getDecorationCost()
        {
            return Convert.ToString(decorationCost);
        }
        public static string getCenterCost()
        {
            return Convert.ToString(totalcenterCost);
        }
        public static string getVat()
        {
            return Convert.ToString(vat);
        }
        public static string getDiscount()
        {
            return Convert.ToString(discount);
        }
        public static string getTotalCost()
        {
            return Convert.ToString(totalCostWithVat);
        }
        public static DateTime getDate()
        {
            return date;
        }
        public static string returnMoneyCalculation(int GivenMoney,int RemainingMoney)
        {
            if (GivenMoney >=RemainingMoney)
            {
                returnMoney =Convert.ToString(GivenMoney - RemainingMoney);
            }
            return returnMoney;
            
        } 
    }
}
