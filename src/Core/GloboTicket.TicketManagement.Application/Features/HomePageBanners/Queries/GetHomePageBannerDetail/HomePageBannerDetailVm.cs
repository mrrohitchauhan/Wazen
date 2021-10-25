using System;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannerDetail
{
    public class HomePageBannerDetailVm
    {
        //public Guid EventId { get; set; }
        public Guid ID { get; set; }
        public string ImageSource { get; set; }
        public Guid ProductID { get; set; }
        public string IsActive { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
