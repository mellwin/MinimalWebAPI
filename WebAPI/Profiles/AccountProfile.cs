using AutoMapper;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile() 
        {
            CreateMap<ReadAccountDto, Account>().ReverseMap();
        }
        
    }
}