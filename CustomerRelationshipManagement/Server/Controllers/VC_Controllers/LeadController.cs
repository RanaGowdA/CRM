using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using CustomerRelationshipManagement.Shared;
using CustomerRelationshipManagement.Shared.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRelationshipManagement.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : Controller
    {
        private readonly ILeadRepository _context;

        public LeadController(ILeadRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public string Get()
        {
            return "LeadControllerConnected";
        }

        // POST: LeadController/Create
        [HttpPost("createLead")]
        public async Task<bool> CreateNewLead(Lead lead)
        {
            return await _context.AddLead(lead);
        }

        // POST: LeadController/Create
        [HttpPost("createOpportunity")]
        public async Task<bool> CreateOpportunity(Lead lead)
        {
            return await _context.AddOpportunity(lead);
        }

        // POST: LeadController/editLead
        [HttpPost("editLead")]
        public Task<bool> EditExistingLead(Lead lead)
        {
            return _context.EditLead(lead);
        }



        // POST: LeadController/editOpportunity
        [HttpPost("editOpportunity")]
        public Task<bool> EditExistingOpportunity(Lead lead)
        {
            return _context.EditOpportunity(lead);
        }

        [HttpPost("editProject")]
        public Task<bool> EditExistingProject(Lead lead)
        {
            return _context.EditProject(lead);
        }

        // POST: LeadController/deleteLead
        [HttpPost("deleteLead")]
        public Task<bool> DeleteLeadById(DataIdDTO leadIdDto)
        {
            return _context.DeleteLead(leadIdDto.Id);
        }

        //[HttpPost("allContacts")]
        //public Task<List<Contacts>> GetAllContacts(DataIdDTO leadIdDto)
        //{
        //    return _context.GetAllContacts(leadIdDto.Id);
        //}

        [HttpPost("allLeads")]
        public async Task<List<Lead>> GetAllLeads(DataIdDTO leadIdDto)
        {
            return await _context.GetAllLeads(leadIdDto.Id);
        }

        [HttpPost("allOpportunity")]
        public async Task<List<Lead>> GetAllOpportunity(DataIdDTO leadIdDto)
        {
            return await _context.GetAllOpportunities(leadIdDto.Id);
        }

        //[HttpPost("allOrganizations")]
        //public Task<List<Organization>> GetAllOrganizations(DataIdDTO leadIdDto)
        //{
        //    return _context.GetAllOrganizations(leadIdDto.Id);
        //}

        [HttpPost("leadsByDates")]
        public Task<List<Lead>> GetLeadsByDates(SearchFromDateToDateDto searchFromDateToDateDto)
        {
            return _context.GetLeadsByDateRange(searchFromDateToDateDto);
        }

        [HttpPost("oppsByDates")]
        public Task<List<Lead>> GetOppsByDates(SearchFromDateToDateDto searchFromDateToDateDto)
        {
            return _context.GetOpportunitiesByDateRange(searchFromDateToDateDto);
        }

        [HttpPost("projectsByDates")]
        public Task<List<Lead>> GetProjectsByDates(SearchFromDateToDateDto searchFromDateToDateDto)
        {
            return _context.GetProjectsByDateRange(searchFromDateToDateDto);
        }
    }
}
