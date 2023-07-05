 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerRelationshipManagement.Shared
{
    public interface IProject
    {
        [Key]
        public int Id { get; set; }
        public ProjectState Status { get; set; }

        public InProgressSubState InpState { get; set; }

        public VisibiltyType Visiblity { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int LastEditedById { get; set; }
        //public AppUser LastEditedBy { get; set; }

        public int CreatedById { get; set; }
        //public AppUser CreatedBy { get; set; }
    }
}
