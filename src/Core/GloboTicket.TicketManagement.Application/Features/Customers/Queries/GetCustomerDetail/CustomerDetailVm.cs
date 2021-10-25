using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Customers.Queries.GetCustomerDetail
{
   public  class CustomerDetailVm
    {
        public Guid ID { get; set; }
        public string Salutation { get; set; }
        public string EnglishFirstName { get; set; }
        public string EnglishMiddleName { get; set; }

        public string EnglishLastName { get; set; }
        public string ArabicFirstName { get; set; }
        public string ArabicMiddleName { get; set; }
        public string ArabicLastName { get; set; }

        public string Address { get; set; }

        public string NationalID { get; set; }
        public string IQAMA { get; set; }
        public string CompanyCR { get; set; }
        public string Email { get; set; }

        public string Mobile { get; set; }
        public string TelephoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public int Occupation { get; set; }

        public int EducationID { get; set; }

        public int MaritalStatusID { get; set; }

        public Boolean IsActive { get; set; }

        //  public int CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string DriverID { get; set; }
    }
}
