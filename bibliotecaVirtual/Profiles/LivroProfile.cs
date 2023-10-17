using AutoMapper;
using bibliotecaVirtual.Data.DTOs;
using bibliotecaVirtual.Models;

namespace bibliotecaVirtual.Profiles
{
    public class LivroProfile : Profile
    {
        public LivroProfile() 
        {
            CreateMap<CreateLivroDTO, Livro>();
            CreateMap<UpdateLivroDTO, Livro>();
        }
    }
}
