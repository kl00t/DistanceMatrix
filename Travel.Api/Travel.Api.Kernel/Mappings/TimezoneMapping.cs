namespace Travel.Api.Kernel.Mappings
{
    using AutoMapper;
    using Connector;
    using Connector.Entities;
    using Resolvers;

    public class TimezoneMapping : Profile
    {
        /// <summary>
        /// The configure.
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<Domain.Models.TimezoneRequest, TimezoneRequest>()
                .ForMember(dest => dest.key, opt => opt.UseValue(ConfigurationHelper.GetAppSetting("Timezone_ApiKey")))
                .ForMember(dest => dest.location, opt => opt.ResolveUsing<LocationsResolver>().FromMember(src => src.Location))
                .ForMember(dest => dest.language, opt => opt.MapFrom(src => src.Language.Code))
                .ForMember(dest => dest.timestamp, opt => opt.MapFrom(src => src.Timestamp));

            Mapper.CreateMap<TimezoneResponse, Domain.Models.TimezoneResponse>()
                .ForMember(dest => dest.DstOffset, opt => opt.MapFrom(src => src.dstOffset))
                .ForMember(dest => dest.RawOffset, opt => opt.MapFrom(src => src.rawOffset))
                .ForMember(dest => dest.TimeZoneId, opt => opt.MapFrom(src => src.timeZoneId))
                .ForMember(dest => dest.TimeZoneName, opt => opt.MapFrom(src => src.timeZoneName))
                .ForMember(dest => dest.Status, opt => opt.ResolveUsing<StatusResolver>().FromMember(src => src.status))
                .ForMember(dest => dest.ErrorMessage, opt => opt.MapFrom(src => src.error_message));
        }
    }
}