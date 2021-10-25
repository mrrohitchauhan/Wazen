using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRoleDetail
{
    public class RoleDetailVm
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; }
        public string RoleArabicName { get; set; }
        public string Description { get; set; }
        public Boolean IsActive { get; set; }
    }
}
