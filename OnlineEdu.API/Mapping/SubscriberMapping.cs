using AutoMapper;
using OnlineEdu.DTO.DTOs.SubscriberDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Mapping
{
    public class SubscriberMapping : Profile
    {
        public SubscriberMapping() {

            CreateMap<CreateSubscriberDTO, Subscriber>().ReverseMap();

            CreateMap<UpdateSubscriberDTO, Subscriber>().ReverseMap();
        }
    }
}
