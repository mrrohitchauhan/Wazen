using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.CreateHomePageBanner
{
    public class CreateHomePageBannerDto
    {
        public Guid ID { get; set; }
        public string ImageSource { get; set; }
        public Guid ProductID { get; set; }
        public bool IsActive { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
