
using CustomerRelationshipManagement.Shared;
using CustomerRelationshipManagement.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Server
{
    public interface ILeadRepository
    {
        Task<bool> AddLead(Lead NewLead);
        Task<bool> EditLead(Lead EditLead);
        Task<bool> DeleteLead(int LeadId);
        Task<List<Lead>> GetAllLeads(int UserId);
        Task<List<Lead>> GetLeadsByDateRange(SearchFromDateToDateDto searchFromDateToDateDto);
        //Task<List<Contacts>> GetAllContacts(int UserId);
        //Task<List<Organization>> GetAllOrganizations(int userId);


        Task<bool> AddOpportunity(Lead NewLead);
        Task<bool> EditOpportunity(Lead EditLead);
        Task<bool> AddProject(Lead NewLead);
        Task<bool> EditProject(Lead EditLead);
        Task<List<Lead>> GetAllOpportunities(int UserId);
        Task<List<Lead>> GetOpportunitiesByDateRange(SearchFromDateToDateDto searchFromDateToDateDto);
        Task<List<Lead>> GetProjectsByDateRange(SearchFromDateToDateDto searchFromDateToDateDto);
    }
}
