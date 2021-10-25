using GloboTicket.TicketManagement.Domain.Common;
using System;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; }
        public string RoleArabicName { get; set; }
        public string Description { get; set; }
        public Boolean IsActive { get; set; }

      
    }
}
