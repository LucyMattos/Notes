using AutoMapper;
using BlocodeNotasApi.Models.DTO;
using BlocodeNotasApi.Models.Entities;

namespace BlocodeNotasApi.Profiles
{
    public class NotesProfile : Profile
    {
        public NotesProfile()
        {
            CreateMap<BlocoDeNotas, AddNotesDTO>().ReverseMap();
            CreateMap<BlocoDeNotas, UpdateNotesDTO>().ReverseMap();
        }
    }
}
