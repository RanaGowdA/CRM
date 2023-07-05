using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerRelationshipManagement.Shared
{
    public interface IOpportunity
    {
        [Key]
        public int Id { get; set; }

        public OpportunityCurrentState Status { get; set; }


        public VisibiltyType Visiblity { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int LastEditedById { get; set; }
        //public AppUser LastEditedBy { get; set; }

        public int CreatedById { get; set; }
        //public AppUser CreatedBy { get; set; }


    }
}
