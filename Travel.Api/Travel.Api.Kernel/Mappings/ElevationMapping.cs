namespace Travel.Api.Kernel.Mappings
{
    using AutoMapper;
    using Connector.Entities;
    using Domain.Interfaces;
    using Resolvers;

    public class ElevationMapping : Profile
    {
        /// <summary>
        /// The configure.
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<Domain.Models.ElevationRequest, ElevationRequest>()
                .ForMember(dest => dest.locations, opt => opt.ResolveUsing<LocationsResolver>().FromMember(src => src));

            Mapper.CreateMap<ElevationResponse, Domain.Models.ElevationResponse>()
                .ForMember(dest => dest.Results, opt => opt.MapFrom(src => src.results))
                .ForMember(dest => dest.Status, opt => opt.ResolveUsing<StatusResolver>().FromMember(src => src.status))
                .ForMember(dest => dest.ErrorMessage, opt => opt.MapFrom(src => src.error_message));

            Mapper.CreateMap<Elevation, Domain.Models.Elevation>()
                .ForMember(dest => ((IElevation)dest).Elevation, opt => opt.MapFrom(src => src.elevation))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.location))
                .ForMember(dest => dest.Resolution, opt => opt.MapFrom(src => src.resolution));

            Mapper.CreateMap<Location, Domain.Models.Location>()
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.lat))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.lng));
        }
    }
}