namespace Travel.Api.Kernel.Mappings
{
    using AutoMapper;
    using Connector;
    using Connector.Entities;
    using Domain.Interfaces;
    using Resolvers;

    public class GeolocationMapping : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Domain.Models.GeolocationRequest, GeolocationRequest>()
                .ForMember(dest => dest.key, opt => opt.UseValue(ConfigurationHelper.GetAppSetting("Geolocation_ApiKey")))
                .ForMember(dest => dest.carrier, opt => opt.MapFrom(src => src.Carrier))
                .ForMember(dest => dest.homeMobileCountryCode, opt => opt.MapFrom(src => src.HomeMobileCountryCode))
                .ForMember(dest => dest.homeMobileNetworkCode, opt => opt.MapFrom(src => src.HomeMobileNetworkCode))
                .ForMember(dest => dest.radioType, opt => opt.MapFrom(src => src.RadioType))
                .ForMember(dest => dest.considerIp, opt => opt.MapFrom(src => src.ConsiderIp.ToString()));

            Mapper.CreateMap<GeolocationResponse, Domain.Models.GeolocationResponse>()
                .ForMember(dest => dest.Status, opt => opt.ResolveUsing<StatusResolver>().FromMember(src => src.status))
                .ForMember(dest => dest.ErrorMessage, opt => opt.MapFrom(src => src.error_message))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.location))
                .ForMember(dest => dest.Accuracy, opt => opt.MapFrom(src => src.accuracy));

            Mapper.CreateMap<CellTower, Domain.Models.CellTower>()
                .ForMember(dest => dest.CellId, opt => opt.MapFrom(src => src.cellId))
                .ForMember(dest => dest.LocationAreaCode, opt => opt.MapFrom(src => src.locationAreaCode))
                .ForMember(dest => dest.MobileCountryCode, opt => opt.MapFrom(src => src.mobileCountryCode))
                .ForMember(dest => dest.MobileNetworkCode, opt => opt.MapFrom(src => src.mobileNetworkCode))
                .ForMember(dest => dest.SignalStrength, opt => opt.MapFrom(src => src.signalStrength))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.age))
                .ForMember(dest => dest.TimingAdvance, opt => opt.MapFrom(src => src.timingAdvance));

            Mapper.CreateMap<WifiAccessPoint, Domain.Models.WifiAccessPoint>()
                .ForMember(dest => dest.MacAddress, opt => opt.MapFrom(src => src.macAddress))
                .ForMember(dest => dest.SignalStrength, opt => opt.MapFrom(src => src.signalStrength))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.age))
                .ForMember(dest => dest.Channel, opt => opt.MapFrom(src => src.channel))
                .ForMember(dest => dest.SignalToNoiseRatio, opt => opt.MapFrom(src => src.signalToNoiseRatio));
        }
    }
}