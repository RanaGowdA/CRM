using CustomerRelationshipManagement.Shared.Models.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared.Models.Interfaces
{
    public interface IAccount
    {
        [Key]
        public int Id { get; set; }

        public GeneralDeatils GeneralDeatils { get; set; }

        public TemplateConfiguration Configuration { get; set; }

        public EngagementModel EngagementModel { get; set; }


        public int CreatedBy { get; set; }


    }
}
