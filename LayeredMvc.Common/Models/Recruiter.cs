namespace LayeredMvc.Common.Models
{
    public class Recruiter
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVisible { get; set; }

        public Recruiter(int id, string companyName, string address, string phoneNumber, bool isVisible)
        {
            Id = id;
            CompanyName = companyName;
            Address = address;
            PhoneNumber = phoneNumber;
            IsVisible = isVisible;
        }
    }
}
