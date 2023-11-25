﻿namespace University.Web.Models.ViewModels
{
#nullable disable
    public class StudentDetailsViewModel
    {
        public int Id { get; set; }
        public string Avatar { get; set; }

        public string NameFirstName { get; set; }
        public string NameLastName { get; set; }
        public string Email { get; set; }

        public string AddressStreet { get; set; }
        public string AddressZipCode { get; set; }

        public string AddressCity { get; set; }

        public int Attending { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
