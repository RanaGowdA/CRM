
using CustomerRelationshipManagement.Server;
using CustomerRelationshipManagement.Server.Data;
using CustomerRelationshipManagement.Shared;
using CustomerRelationshipManagement.Shared.Dto;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using static MudBlazor.CategoryTypes;

namespace CRM.Server.Repos.RepoImplementation
{
    public class LeadRepository : ILeadRepository
    {
        private readonly CRMDbContext _context;

        public LeadRepository(CRMDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddLead(Lead NewLead)
        {
            try
            {
                if (NewLead.LeadStatus == LeadStatus.Closed_Qualified)
                {
                    NewLead.IsOpportunity = true;
                    NewLead.Opportunity.CreatedOn = DateTime.Now;
                    NewLead.Opportunity.ModifiedOn = DateTime.Now;
                    NewLead.Opportunity.CreatedById = NewLead.CreatedById;
                }
                _context.Leads.Add(NewLead);
                var result = await _context.SaveChangesAsync();
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return false;
        }

        public async Task<bool> AddOpportunity(Lead NewLead)
        {
            try
            {
                NewLead.LeadStatus = LeadStatus.Closed_Qualified;
                NewLead.IsOpportunity = true;
                NewLead.Opportunity.CreatedOn = DateTime.Now;
                NewLead.Opportunity.ModifiedOn = DateTime.Now;
                NewLead.Opportunity.CreatedById = NewLead.CreatedById;
                _context.Leads.Add(NewLead);
                var result = await _context.SaveChangesAsync();
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return false;
        }

        public async Task<bool> AddProject(Lead NewLead)
        {
            try
            {  // Update Opportunity If Closed Qaulitfied 
                if (NewLead.Project.Status == ProjectState.Completed)
                {
                    NewLead.IsProject = true;
                    NewLead.Project.CreatedOn = DateTime.Now;
                    NewLead.Project.CreatedById = NewLead.CreatedById;
                }
                NewLead.LeadStatus = LeadStatus.Closed_Qualified;
                NewLead.Opportunity.Status = OpportunityCurrentState.Won;
                NewLead.IsOpportunity = true;
                NewLead.IsProject = true;
                NewLead.Opportunity.CreatedOn = DateTime.Now;
                NewLead.Opportunity.ModifiedOn = DateTime.Now;
                NewLead.Opportunity.CreatedById = NewLead.CreatedById;
                NewLead.Project.CreatedById = NewLead.CreatedById;
                _context.Leads.Add(NewLead);
                var result = await _context.SaveChangesAsync();
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return false;
        }

        public async Task<bool> DeleteLead(int LeadId)
        {
            var savedLead = await _context.Leads.Where(s => s.LeadId == LeadId).Include(x => x.Opportunity).Include(x => x.Project).FirstOrDefaultAsync();
            if (savedLead != null)
            {
                try
                {
                    _context.Leads.Remove(savedLead);
                    await _context.SaveChangesAsync();
                    var afterSavedLead = await _context.SaveChangesAsync(); if (afterSavedLead > 0)
                    {
                        return true;
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return false;
        }

        public async Task<bool> EditLead(Lead EditLead)
        {
            var savedLead = await _context.Leads.Where(s => s.LeadId == EditLead.LeadId).Include(x => x.Opportunity).Include(x => x.Project).FirstOrDefaultAsync();
            if (savedLead != null)
            {
                EditLead.ModifiedOn = DateTime.UtcNow;
                // Update Opportunity If Closed Qaulitfied  
                EditLead.IsOpportunity = false;
                if (EditLead.LeadStatus == LeadStatus.Closed_Qualified && !savedLead.IsOpportunity)
                {
                    EditLead.IsOpportunity = true;
                    EditLead.Opportunity.CreatedOn = DateTime.UtcNow;
                    EditLead.Opportunity.CreatedById = EditLead.CreatedById;
                }
                else
                {
                    EditLead.IsOpportunity = false;
                    EditLead.IsProject = false;
                }

                try
                {
                    _context.Entry(savedLead).CurrentValues.SetValues(EditLead);
                    var result = await _context.SaveChangesAsync();
                    if (result > 0)
                    {
                        return true;
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return false;
        }

        public async Task<bool> EditOpportunity(Lead EditLead)
        {
            var savedLead = await _context.Leads.Where(s => s.LeadId == EditLead.LeadId).Include(x => x.Opportunity).Include(x => x.Project).FirstOrDefaultAsync();
            if (savedLead != null)
            {
                // Update Opportunity If Closed Qaulitfied 
                if (EditLead.Opportunity.Status == OpportunityCurrentState.Won)
                {
                    EditLead.IsProject = true;
                    if (EditLead.Project.CreatedOn == DateTime.Parse("0001-01-01 00:00:00"))
                    {
                        EditLead.Project.CreatedOn = DateTime.UtcNow;
                    }
                    EditLead.Project.CreatedById = EditLead.CreatedById;
                    EditLead.Opportunity.ModifiedOn = DateTime.UtcNow;
                    EditLead.Opportunity.Status = EditLead.Opportunity.Status;
                }
                else
                {
                    EditLead.Opportunity.ModifiedOn = DateTime.UtcNow;
                    EditLead.Opportunity.LastEditedById = EditLead.CreatedById;
                    EditLead.Opportunity.Status = EditLead.Opportunity.Status;
                    EditLead.Project.Status = ProjectState.None;
                    EditLead.Project.InpState = InProgressSubState.None;
                    EditLead.Project.PaymentStatus = PaymentStatus.None;
                    EditLead.IsProject = false;
                }

                try
                {
                    _context.Entry(savedLead).CurrentValues.SetValues(EditLead);
                    var result = await _context.SaveChangesAsync();
                    if (result > 0)
                    {
                        var savedLead3 = await _context.Leads.Where(s => s.LeadId == EditLead.LeadId).Include(x => x.Opportunity).Include(x => x.Project).FirstOrDefaultAsync();
                        return true;
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return false;
        }

        public async Task<bool> EditProject(Lead EditLead)
        {
            var savedLead = await _context.Leads.Where(s => s.LeadId == EditLead.LeadId).Include(x => x.Opportunity).Include(x => x.Project).FirstOrDefaultAsync();
            if (savedLead != null)
            {
                savedLead.Project.Status = EditLead.Project.Status;
                savedLead.Project.InpState = EditLead.Project.InpState;
                savedLead.Project.PaymentStatus = EditLead.Project.PaymentStatus;
                savedLead.Opportunity.LastEditedById = EditLead.CreatedById;
                // Update Opportunity If Closed Qaulitfied 
                if (EditLead.Opportunity.Status == OpportunityCurrentState.Won && savedLead.IsOpportunity)
                {
                    savedLead.IsProject = true;
                    if (EditLead.Project.CreatedOn == DateTime.Parse("0001-01-01 00:00:00"))
                    {
                        savedLead.Project.CreatedById = EditLead.CreatedById;
                        savedLead.Project.CreatedOn = DateTime.UtcNow;
                    }
                    else
                    {
                        savedLead.Project.ModifiedOn = DateTime.UtcNow;
                    }
                }
                else
                {
                    savedLead.Project.ModifiedOn = DateTime.UtcNow;
                    savedLead.IsProject = false;
                }

                try
                {
                    _context.Entry(savedLead).CurrentValues.SetValues(EditLead);
                    var result = await _context.SaveChangesAsync();
                    if (result > 0)
                    {
                        return true;
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return false;
        }

        //public async Task<List<Contacts>> GetAllContacts(int UserId)
        //{
        //    return await _context.Leads.Where(x => x.CreatedById == UserId).Select(x => new Contacts
        //    {
        //        FirstName = x.Name,
        //        LastName = x.LastName,
        //        Address = x.Address1,
        //        Title = x.Title,
        //        ContactNumber = x.Phone,
        //        Email = x.EmailAddress,
        //        Fax = x.Fax
        //    }).ToListAsync();
        //}

        public async Task<List<Lead>> GetAllLeads(int UserId)

        {
            var result = await _context.Leads.Where(x => x.CreatedById == UserId).Include(x => x.Opportunity).Include(x => x.Project).ToListAsync();
            return result;
        }

        public async Task<List<Lead>> GetAllOpportunities(int UserId)
        {
            return await _context.Leads.Where(x => x.CreatedById == UserId && x.IsOpportunity).Include(x => x.Opportunity).Include(x => x.Project).ToListAsync();
        }

        //public async Task<List<Organization>> GetAllOrganizations(int UserId)
        //{
        //    return await _context.Leads.Where(x => x.CreatedById == UserId).Select(x => new Organization
        //    {
        //        Name = x.Organization,
        //        Address = x.Address1,
        //        ContactNumber = x.Phone,
        //        Email = x.EmailAddress,
        //        Fax = x.Fax,
        //        Industry = x.Industry,
        //        WebSite = x.WebSite
        //    }).ToListAsync();
        //}

        public async Task<List<Lead>> GetLeadsByDateRange(SearchFromDateToDateDto sFDTD)
        {
            var result = await _context.Leads.Where(x => x.CreatedById == sFDTD.UserId && x.CreatedOn >= sFDTD.StartDate && x.ModifiedOn <= sFDTD.EndDate)
                                                    .Include(x => x.Opportunity).Include(x => x.Project).ToListAsync();
            return result;
        }

        public async Task<List<Lead>> GetOpportunitiesByDateRange(SearchFromDateToDateDto sFDTD)
        {
            var result = await _context.Leads.Where(x => x.CreatedById == sFDTD.UserId && x.CreatedOn >= sFDTD.StartDate
                                                    && x.ModifiedOn <= sFDTD.EndDate && x.IsOpportunity)
                                                    .Include(x => x.Opportunity).Include(x => x.Project).ToListAsync();

            return result;
        }

        public async Task<List<Lead>> GetProjectsByDateRange(SearchFromDateToDateDto sFDTD)
        {
            var result = await _context.Leads.Where(x => x.CreatedById == sFDTD.UserId && x.CreatedOn >= sFDTD.StartDate
                                                    && x.ModifiedOn <= sFDTD.EndDate && x.IsOpportunity && x.IsProject)
                                                    .Include(x => x.Opportunity).Include(x => x.Project).ToListAsync();


            return result;
        }
    }
}
