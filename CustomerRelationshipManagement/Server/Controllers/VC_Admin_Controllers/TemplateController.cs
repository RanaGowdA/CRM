using CustomerRelationshipManagement.Server.Repo.RepoInterfaces;
using CustomerRelationshipManagement.Shared;
using CustomerRelationshipManagement.Shared.Dto;
using CustomerRelationshipManagement.Shared.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerRelationshipManagement.Server.Controllers.VC_Admin_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateController : Controller
    {
        public IAdministration _adminContext { get; set; }
        public TemplateController(IAdministration administrationContext)
        {
            _adminContext = administrationContext;
        }

        [HttpGet]
        public string Get()
        {
            return "TemplateControllerConnected";
        }

        // POST: Template/addEM
        [HttpPost("addEM")]
        public async Task<bool> CreateNewLead(EngagementModel engagementModel)
        {
            return await _adminContext.AddEngagementModelEng(engagementModel);
        }

        // GET: Template/allEM
        [HttpGet("allEM")]
        public async Task<List<EngagementModel>> GetAllEngagementModelEng()
        {
            return await _adminContext.GetEngagementModels();
        }

        // GET: Template/allTmpConfig
        [HttpGet("allTmpConfig")]
        public async Task<List<TemplateConfiguration>> GetAllTemplateConfiguration()
        {
            return await _adminContext.GetTemplateConfigurations();
        }


    }
}
