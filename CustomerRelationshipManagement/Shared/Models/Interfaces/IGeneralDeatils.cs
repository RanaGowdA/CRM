using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared.Models.Interfaces
{
    public interface IGeneralDeatils
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        public string Organization { get; set; }
          
        public string EmailAddress { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string MobilePhone { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Fax { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string WebSite { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Industry { get; set; }

        public int NumberOfEmployees { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Address1 { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string State { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public int PostalCode { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Country { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public Geo Geo { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Description { get; set; }
    }
}
