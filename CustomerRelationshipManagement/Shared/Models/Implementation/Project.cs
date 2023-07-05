namespace CustomerRelationshipManagement.Shared
{
    public class Project : IProject
    {

        public int Id { get; set; }
        public ProjectState Status { get; set; }
        public InProgressSubState InpState { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public VisibiltyType Visiblity { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int LastEditedById { get; set; }
        public int CreatedById { get; set; }
        public Lead Lead { get; set; } = null!;
        public Project()
        {
            Status = ProjectState.None;
            InpState = InProgressSubState.None;
            PaymentStatus = PaymentStatus.None; 
        }
    }
}
