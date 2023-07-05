namespace CustomerRelationshipManagement.Shared
{
    public class Opportunity : IOpportunity
    {
        public int Id { get; set; }
        public OpportunityCurrentState Status { get; set; }
        public VisibiltyType Visiblity { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int LastEditedById { get; set; }
        public int CreatedById { get; set; }

        public Lead Lead { get; set; } = null!;
        public Opportunity()
        {
            Status = OpportunityCurrentState.Qualified;
            Visiblity = VisibiltyType.None; 
        }
    }
}
