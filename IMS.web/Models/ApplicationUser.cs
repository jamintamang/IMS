using Microsoft.AspNetCore.Identity;

namespace IMS.web.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string  MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        //public string UserName { get; set; }
        //public string PhoneNumber { get; set; }

        public string StoreId { get; set; }
        public int UserRoleId { get; set; }
        public string ProfileUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTime  CreatedDate { get; set; }
         public string CreateBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
