using _10_AutoMapper.Dto;
using _10_AutoMapper.Models;
using AutoMapper;

namespace _10_AutoMapper.MappingProfile 
{
    public class UserProfile:Profile
    {
        //Profile eşleşme (mapping) kurallarının toplandığı sınıf Program.cs te assembly taraması ile otomatik bulunacak.
        public UserProfile()
        {
            //Firstname yapısını ve lastname yapısını fullname yapısına aktardık formember ile elle tanımladık
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
            //fullname:Erkan Türk
            //Boşluğa göre algılatıp ters yönde işlem yaptık fullname i firstname ve lastname e gönderdik
            CreateMap<UserDto, User>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FullName.Split(' ', StringSplitOptions.None)[0]))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FullName.Contains(' ') ?
                src.FullName.Substring(src.FullName.IndexOf(' ') + 1) : string.Empty));


        }
    }
}
