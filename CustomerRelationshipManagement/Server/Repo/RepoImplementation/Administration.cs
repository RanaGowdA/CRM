using CustomerRelationshipManagement.Server.Data;
using CustomerRelationshipManagement.Server.Repo.RepoInterfaces;
using CustomerRelationshipManagement.Shared.Dto;
using CustomerRelationshipManagement.Shared.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CustomerRelationshipManagement.Server.Repo.RepoImplementation
{
    public class Administration : IAdministration
    {
        private readonly CRMDbContext _context;

        public Administration(CRMDbContext context)
        {
            _context = context;
        }

        public Task<bool> AddEngagementModelEng(EngagementModel engagementModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddTemplateConfiguration(TemplateConfiguration templateConfiguration)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEngagementModel(DataIdDTO dataIdDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTemplateConfigurations(TemplateConfiguration templateConfiguration)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditEngagementModel(DataIdDTO dataIdDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditTemplateConfigurations(TemplateConfiguration templateConfiguration)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EngagementModel>> GetEngagementModels()
        {
            return await _context.EngagementModels.ToListAsync();
        }

        public async Task<List<TemplateConfiguration>> GetTemplateConfigurations()
        {
            return await _context.TemplateConfigurations.ToListAsync();
        }
    }
}
