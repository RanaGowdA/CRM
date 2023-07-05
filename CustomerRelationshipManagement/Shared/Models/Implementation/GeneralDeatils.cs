using CustomerRelationshipManagement.Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared.Models.Implementation
{
    public class GeneralDeatils : IGeneralDeatils
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string LastName {get;set;}
        public string Title {get;set;}
        public string Organization {get;set;}
        public string EmailAddress {get;set;}
        public string Phone {get;set;}
        public string MobilePhone {get;set;}
        public string Fax {get;set;}
        public string WebSite {get;set;}
        public string Industry {get;set;}
        public int NumberOfEmployees {get;set;}
        public string Address1 {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public int PostalCode {get;set;}
        public string Country {get;set;}
        public Geo Geo {get;set;}
        public string Description {get;set;}
    }
}
