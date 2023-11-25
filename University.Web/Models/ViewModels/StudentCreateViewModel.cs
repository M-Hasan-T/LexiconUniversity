using University.Web.Validations;

namespace University.Web.Models.ViewModels
{
#nullable disable
    public class StudentCreateViewModel
    {

        public string NameFirstName { get; set; }
        public string NameLastName { get; set; }
        public string Email { get; set; }

        [CheckStreetNr]
        public string AddressStreet { get; set; }
        public string AddressZipCode { get; set; }
        public string AddressCity { get; set; }
    }
}
