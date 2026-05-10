using AutoMapper;
using OnlineEdu.DTO.DTOs.MessageDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<CreateMessageDTO, Message>().ReverseMap();

            CreateMap<UpdateMessageDTO, Message>().ReverseMap();
        }
    }
}
