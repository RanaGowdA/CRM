using CustomerRelationshipManagement.Shared.Models.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared.Models.Interfaces
{
    // Dependent (child)
    public class TemplateConfiguration
    {
        [Key]
        public int Id { get; set; }
        public string Segment { get; set; }
        public string SegmentOntology { get; set; }
        public string City { get; set; }
        public string CityOntology { get; set; }
        public string Region { get; set; }
        public string RegionOntology { get; set; }
        public string Name { get; set; }
        public string NameOntology { get; set; }

        public int ClientAccountId { get; set; } // Required foreign key property
        public ClientAccount ClientAccount { get; set; } = null!; // Required reference navigation to principal [one-to-one with shadow foreign key]


        //[One-to-one without navigation to principal and with shadow foreign key]


        public TemplateConfiguration()
        {
            Segment = string.Empty;
            City = string.Empty;
            Region = string.Empty;
            Name = string.Empty;
        }
    }
}
