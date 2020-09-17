using System;
using System.Collections.Generic;

namespace ClearSaleIntegration.Models
{
    public class InclusionOfOrders
    {
        public string code { get; set; }
        public string sessionID { get; set; }
        public DateTime date { get; set; }
        public string email { get; set; }
        public string b2bB2c { get; set; }
        public double itemValue { get; set; }
        public double totalValue { get; set; }
        public int numberOfInstallments { get; set; }
        public string ip { get; set; }
        public string giftMessage { get; set; }
        public string observation { get; set; }
        public int status { get; set; }
        public string origin { get; set; }
        public string channelID { get; set; }
        public DateTime reservationDate { get; set; }
        public int product { get; set; }
        public Billing billing { get; set; }
        public Shipping shipping { get; set; }
        public List<Payment> payments { get; set; }
        public List<Item> items { get; set; }
        public List<Passenger> passengers { get; set; }
        public List<Connection> connections { get; set; }
    }
    public class Address
    {
        public string street { get; set; }
        public string number { get; set; }
        public string additionalInformation { get; set; }
        public string county { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public string reference { get; set; }
    }

    public class Phone
    {
        public int type { get; set; }
        public int ddi { get; set; }
        public int ddd { get; set; }
        public int number { get; set; }
        public string extension { get; set; }
    }

    public class Billing
    {
        public string clientID { get; set; }
        public int type { get; set; }
        public string primaryDocument { get; set; }
        public string secondaryDocument { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Address address { get; set; }
        public List<Phone> phones { get; set; }
    }

    public class Address2
    {
        public string street { get; set; }
        public string number { get; set; }
        public string additionalInformation { get; set; }
        public string county { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public string reference { get; set; }
    }

    public class Phone2
    {
        public int type { get; set; }
        public int ddi { get; set; }
        public int ddd { get; set; }
        public int number { get; set; }
        public string extension { get; set; }
    }

    public class Shipping
    {
        public string clientID { get; set; }
        public int type { get; set; }
        public string primaryDocument { get; set; }
        public string secondaryDocument { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Address2 address { get; set; }
        public List<Phone2> phones { get; set; }
        public string deliveryTime { get; set; }
        public double price { get; set; }
    }

    public class Card
    {
        public string number { get; set; }
        public string hash { get; set; }
        public string bin { get; set; }
        public string end { get; set; }
        public int type { get; set; }
        public string validityDate { get; set; }
        public string ownerName { get; set; }
        public string document { get; set; }
        public string nsu { get; set; }
    }

    public class Payment
    {
        public int sequential { get; set; }
        public DateTime date { get; set; }
        public double value { get; set; }
        public int type { get; set; }
        public int installments { get; set; }
        public Card card { get; set; }
    }

    public class Item
    {
        public string code { get; set; }
        public string name { get; set; }
        public double value { get; set; }
        public int amount { get; set; }
        public int categoryID { get; set; }
        public string categoryName { get; set; }
    }

    public class Passenger
    {
        public string name { get; set; }
        public string companyMileCard { get; set; }
        public string mileCard { get; set; }
        public int identificationType { get; set; }
        public string identificationNumber { get; set; }
        public string gender { get; set; }
        public DateTime birthdate { get; set; }
        public string cpf { get; set; }
    }

    public class Connection
    {
        public string company { get; set; }
        public int identificationNumber { get; set; }
        public DateTime date { get; set; }
        public string seatClass { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime boarding { get; set; }
        public DateTime arriving { get; set; }
        public string fareClass { get; set; }
    }
    
}
