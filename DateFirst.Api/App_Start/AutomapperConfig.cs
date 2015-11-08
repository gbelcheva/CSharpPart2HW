namespace DateFirst.Api.App_Start
{
    using AutoMapper;
    using DateFirst.Models;
    using DataTransferModels;

    public class AutomapperConfig
    {
        public static void Initialize()
        {
            //// TODO more custom mapping when final models are decided
            Mapper.CreateMap<Hobby, HobbyTransferModel>();
            Mapper.CreateMap<Town, TownTransferModel>();
            Mapper.CreateMap<Department, DepartmentTransferModel>();
            Mapper.CreateMap<Image, ImageTransferModel>()
                .ForMember(i => i.Username, opt => opt.MapFrom(i => i.User.UserName));
            Mapper.CreateMap<AdditionalInfo, AdditionalInfoTransferModel>();
            Mapper.CreateMap<UserProfile, UserTransferModel>().ReverseMap();
            Mapper.CreateMap<Notification, NotificationTransferModel>()
                .ForMember(n => n.ReceiverUsername, opt => opt.MapFrom(n => n.Receiver.UserName))
                .ForMember(n => n.SenderUsername, opt => opt.MapFrom(n => n.Sender.UserName));
            Mapper.CreateMap<Post, PostTransferModel>()
                .ForMember(p => p.ReceiverUsername, opt => opt.MapFrom(p => p.Receiver.UserName))
                .ForMember(p=>p.SenderUsername, opt => opt.MapFrom(p => p.Sender.UserName));
        }
    }
}