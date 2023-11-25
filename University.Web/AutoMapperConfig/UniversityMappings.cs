using AutoMapper;

namespace University.Web.AutoMapperConfig
{
    public class UniversityMappings : Profile
    {
        public UniversityMappings()
        {
            CreateMap<Student, StudentCreateViewModel>()
                .ReverseMap();

            CreateMap<Student, StudentIndexViewModel>();
            CreateMap<Student, StudentDetailsViewModel>()
                .ForMember(
                dest => dest.Attending,
                from => from.MapFrom(s => s.Courses.Count));
        }

    }
}
