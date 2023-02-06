using AutoMapper;
using OTO.Model;

namespace OTO
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, Studentdto>().ReverseMap();
            //CreateMap<Studentdto, Student>();
        }
    }
}
