
using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public record ContactInfo(string PhoneNumber, string Email);
    public record AddressInfo (string Country, string City, string District, string Street, string BuildingNumber, string ZipCode);

    public class Person: BaseDeletableEntity

    {
        private Person() { }
        public Person(string name, byte gendor, string nationalID, string bloodGroup, string photo, ContactInfo contactInformation, AddressInfo addressInformation, DateTime dateOfBirth)
        {
            Name = name;
            Gendor = gendor;
            NationalID = nationalID;
            BloodGroup = bloodGroup;
            Photo = photo;
            ContactInformation = contactInformation;
            AddressInformation = addressInformation;
            DateOfBirth = dateOfBirth;
        }
        public string Name { get;private set; }= string.Empty;
        public byte Gendor { get; private set; }
         public string NationalID { get; private set; }=string.Empty;
        public string BloodGroup { get; private set; }=string.Empty;
        public string Photo { get; private set; }=string.Empty;
        public ContactInfo ContactInformation = new ContactInfo(string.Empty, string.Empty);
        public AddressInfo AddressInformation { get; private set; }=new AddressInfo(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

        public DateTime DateOfBirth { get; private set; }
        public Person Add(string name, byte gendor, string nationalID, string bloodGroup, string photo, DateTime dateOfBirth,string phonenumbrt,string email, string Country, string City, string District, string Street, string BuildingNumber, string ZipCode)=>
            new Person(name, gendor, nationalID, bloodGroup, photo, new ContactInfo(phonenumbrt,email), new AddressInfo(Country, City, District, Street, BuildingNumber, ZipCode), dateOfBirth);

        public void Update(string name, byte gendor, string nationalID, string bloodGroup, string photo, ContactInfo contactInformation, AddressInfo addressInformation, DateTime dateOfBirth)
        {
            Name = name;
            Gendor = gendor;
            NationalID = nationalID;
            BloodGroup = bloodGroup;
            Photo = photo;
            ContactInformation = contactInformation;
            AddressInformation = addressInformation;
            DateOfBirth = dateOfBirth;
        }




    }
}
