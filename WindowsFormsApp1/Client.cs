using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Client
    {
        protected readonly string FirstName, LastName, Age, Email, Country, VisaCard, Password, PhonNumber;
        protected int Amount = 0;
        /*private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;
        private string text7;
        private string text8;

        public Client(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
            this.text7 = text7;
            this.text8 = text8;
        }*/
        public Client(string Email, string Password, string FirstName, string LastName, string Country,
                       string Age, string VisaCard, string PhonNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.VisaCard = VisaCard;
            this.Email = Email;
            this.Country = Country;
            this.Age = Age;
            this.Password = Password;
            this.PhonNumber = PhonNumber;
        }
        public Client(string Email, string Password, string FirstName, string LastName, string Country,
                       string Age, string VisaCard, string PhonNumber, bool Vip)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.VisaCard = VisaCard;
            this.Email = Email;
            this.Country = Country;
            this.Age = Age;
            this.Password = Password;
            this.PhonNumber = PhonNumber;
            if (Vip) Amount = 10;
        }


        public Client(string Email, string Password, string FirstName, string LastName, string Country,
                      string Age, string VisaCard, string PhonNumber, int Amount)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.VisaCard = VisaCard;
            this.Email = Email;
            this.Country = Country;
            this.Age = Age;
            this.Password = Password;
            this.PhonNumber = PhonNumber;
            this.Amount = Amount;

        }
       
        public string Firstname
        {
            get { return FirstName; }
        }
        public string Lastname
        {
            get { return LastName; }
        }
        public string EmailI
        {
            get { return Email; }
        }
        public string Countried
        {
            get { return Country; }
        }
        public string Aged
        {
            get { return Age; }
        }
        public string Pass
        {
            get { return Password; }
        }
        public string Visa
        {
            get { return VisaCard; }
        }
        public string Phone
        {
            get { return PhonNumber; }
        }
        public int AmountI
        {
            set { Amount = value; }
            get { return Amount; }
        }
    }
}
