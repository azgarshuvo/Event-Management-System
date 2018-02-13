using System;

namespace EventList
{
   public class EventsList
    {
        private string eventId;
        private string eventDate;
        private string startTime;
        private string photographyCost;
        private string decorationCost;
        private string centerCost;
        private string vat;
        private string discount;
        private string totalCost;
        private string advancePayment;
        private string remaining;
        private string customerName;
        private string customerContactNo;
        private string customerEmail;
        private string customerAddress;
        private string packageId;
        private string packageCost;
        private string paymentStatus;

        public string EventId
        {
            set
            {
                this.eventId = value;
            }
            get
            {
                return eventId;
            }
        }

        public string EventDate
        {
            get
            {
                return eventDate;
            }

            set
            {
                eventDate = value;
            }
        }

        public string StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public string PhotographyCost
        {
            get
            {
                return photographyCost;
            }

            set
            {
                photographyCost = value;
            }
        }

        public string DecorationCost
        {
            get
            {
                return decorationCost;
            }

            set
            {
                decorationCost = value;
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

        public string Vat
        {
            get
            {
                return vat;
            }

            set
            {
                vat = value;
            }
        }

        public string Discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        public string TotalCost
        {
            get
            {
                return totalCost;
            }

            set
            {
                totalCost = value;
            }
        }

        public string AdvancePayment
        {
            get
            {
                return advancePayment;
            }

            set
            {
                advancePayment = value;
            }
        }

        public string Remaining
        {
            get
            {
                return remaining;
            }

            set
            {
                remaining = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string CustomerContactNo
        {
            get
            {
                return customerContactNo;
            }

            set
            {
                customerContactNo = value;
            }
        }

        public string CustomerEmail
        {
            get
            {
                return customerEmail;
            }

            set
            {
                customerEmail = value;
            }
        }

        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }

            set
            {
                customerAddress = value;
            }
        }

        public string PackageId
        {
            get
            {
                return packageId;
            }

            set
            {
                packageId = value;
            }
        }

        public string PackageCost
        {
            get
            {
                return packageCost;
            }

            set
            {
                packageCost = value;
            }
        }
        public string PaymentStatus
        {
            get
            {
                return this.paymentStatus;
            }
            set
            {
                this.paymentStatus = value;
            }
        }

        public EventsList(string eventId, string eventDate = "unknown", string startTime = "unknown", double photographyCost = 0, double decorationCost=0, double centerCost=0, double vat = 0, double discount = 0, double totalCost = 0, string advancePayment = "unknown", string remaining = "unknown", string customerName = "unknown", string customerContactNo = "unknown", string customerEmail = "unknown", string customerAddress = "unknown",string payment = "Pending" )
        {
            EventId = eventId;
            EventDate = eventDate;
            StartTime = startTime;
            PhotographyCost = Convert.ToString(photographyCost);
            DecorationCost = Convert.ToString(decorationCost);
            CenterCost = Convert.ToString(centerCost);
            Vat = Convert.ToString(vat);
            Discount = Convert.ToString(discount);
            TotalCost = Convert.ToString(totalCost);
            AdvancePayment = advancePayment;
            Remaining = remaining;
            CustomerName = customerName;
            CustomerContactNo = customerContactNo;
            CustomerEmail = customerEmail;
            CustomerAddress = customerAddress;
            packageId = "none";
            packageCost = "0";
            PaymentStatus = paymentStatus;
        }
        public EventsList(string eventId, string eventDate = "unknown", string startTime = "unknown", double photographyCost = 0, double decorationCost = 0, double centerCost = 0, double vat = 0, double discount = 0, double totalCost = 0, string advancePayment = "unknown", string remaining = "unknown", string customerName = "unknown", string customerContactNo = "unknown", string customerEmail = "unknown", string customerAddress = "unknown",string packageId="None",string packageCost="0",string paymentStatus="Pending")
        {
            EventId = eventId;
            EventDate = eventDate;
            StartTime = startTime;
            PhotographyCost = Convert.ToString(photographyCost);
            DecorationCost = Convert.ToString(decorationCost);
            CenterCost = Convert.ToString(centerCost);
            Vat = Convert.ToString(vat);
            Discount = Convert.ToString(discount);
            TotalCost = Convert.ToString(totalCost);
            AdvancePayment = advancePayment;
            Remaining = remaining;
            CustomerName = customerName;
            CustomerContactNo = customerContactNo;
            CustomerEmail = customerEmail;
            CustomerAddress = customerAddress;
            PackageId = packageId;
            PackageCost = packageCost;
            PaymentStatus = paymentStatus;
        }

    }
}
