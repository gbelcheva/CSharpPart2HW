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
            Mapper.CreateMap<Hobby, HobbyTransferModel>().ReverseMap();
            Mapper.CreateMap<Town, TownTransferModel>().ReverseMap();
            Mapper.CreateMap<Department, DepartmentTransferModel>().ReverseMap();
            Mapper.CreateMap<Image, ImageTransferModel>()
                .ForMember(i => i.Username, opt => opt.MapFrom(i => i.User.UserName));
            Mapper.CreateMap<AdditionalInfo, AdditionalInfoTransferModel>().ReverseMap();
            Mapper.CreateMap<User, UserTransferModel>().ReverseMap();
            Mapper.CreateMap<Notification, NotificationTransferModel>()
                .ForMember(n => n.ReceiverUsername, opt => opt.MapFrom(n => n.Receiver.UserName))
                .ForMember(n => n.SenderUsername, opt => opt.MapFrom(n => n.Sender.UserName));
            Mapper.CreateMap<Post, PostTransferModel>()
                .ForMember(p => p.ReceiverUsername, opt => opt.MapFrom(p => p.Receiver.UserName))
                .ForMember(p=>p.SenderUsername, opt => opt.MapFrom(p => p.Sender.UserName));
        }
    }
}