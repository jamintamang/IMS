namespace IMS.web.Models
{
    public class ApplicationUser
    {
        public string FirstName { get; set; }
        public string  MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }

        public string DeportmentId { get; set; }
        public int UserRoleId { get; set; }
        public bool IsActive { get; set; }
        public bool ProfilePicture   { get; set; }
        public string ProfilePictureUrl { get; set;}
        public DateTime  CreatedDate { get; set; }
         public string CreateBy { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }

    }
}
