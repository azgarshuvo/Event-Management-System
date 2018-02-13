using System;

namespace MemberList
{
    public class Members
    {
        private readonly string memberId;
        private string memberName;
        private string memberPosition;
        private string dateOfBirth;
        private string contactNumber;
        private string joinDate;
        private string email;
        private string address;
        private string salary;
        private string available;
        private string password;
        private string securityQuestion;

        public Members() { }
        public Members(string Id, string Name, string Contact, string Email, string Salary)
        {
            memberId = Id;
            MemberName = Name;
            contactNumber = Contact;
            email = Email;
            salary = Salary;
        }
        public Members(string memberName, string memberPosition, string dateOfBirth, string contactNumber, string joinDate, string email, string address, string salary)
        {
            if ((memberPosition.Equals("Photographer")) || (memberPosition.Equals("photographer")))
            { memberId = joinDate[0]+""+ joinDate[1] + "-" + joinDate[8]+"" + joinDate[9] + "-" + dateOfBirth[0]+"" + dateOfBirth[1] + "P"; }
            if ((memberPosition.Equals("Manager")) ||( memberPosition.Equals("manager")))
            { memberId = joinDate[0]+"" + joinDate[1] + "-" + joinDate[8]+"" + joinDate[9] + "-" + dateOfBirth[0]+"" + dateOfBirth[1] + "M"; }
            if ((memberPosition.Equals("Staff")) || (memberPosition.Equals("staff")))
            { memberId = joinDate[0]+"" + joinDate[1] + "-" + joinDate[8]+"" + joinDate[9] + "-" + dateOfBirth[0]+"" + dateOfBirth[1] + "S"; }
            this.memberName = memberName;
            this.memberPosition = memberPosition;
            this.dateOfBirth = dateOfBirth;
            this.contactNumber = contactNumber;
            this.joinDate = joinDate;
            this.email = email;
            this.address = address;
            this.salary = salary;
            available = "available";
            password = "12345";
            securityQuestion = "Not Set";
        }

        //setter getter
        public string MemberId
        {
            get { return memberId; }
        }
        public string MemberName
        {
            set { memberName = value; }
            get { return memberName; }
        }
        public string MemberPosition
        {
            set { memberPosition = value; }
            get { return memberPosition; }
        }
        public string DateOfBirth
        {
            set { dateOfBirth = value; }
            get { return dateOfBirth; }
        }
        public string ContactNumber
        {
            set { contactNumber = value; }
            get { return contactNumber; }
        }
        public string JoinDate
        {
            get { return joinDate; }
            set { joinDate = value; }
        }
        public string Email
        {
            set { email = value ; }
            get { return email; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public string Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public string Available
        {
            set { available = value; }
            get { return available; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public string SecurityQuestion
        {
            set { securityQuestion = value; }
            get { return securityQuestion; }
        }
    }
}
