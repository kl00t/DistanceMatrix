namespace Travel.Api.Kernel.Mappings
{
    using AutoMapper;
    using Connector;
    using Resolvers;
    using Connector.Entities;

    public class GeocodeMapping : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Domain.Models.GeocodeRequest, BingMapsRESTToolkit.GeocodeRequest>()
                .ForMember(dest => dest.Query, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.Address, opt => opt.Ignore())
                .ForMember(dest => dest.IncludeIso2, opt => opt.Ignore())
                .ForMember(dest => dest.IncludeNeighborhood, opt => opt.Ignore())
                .ForMember(dest => dest.MaxResults, opt => opt.Ignore())
                .ForMember(dest => dest.BingMapsKey, opt => opt.UseValue(ConfigurationHelper.GetAppSetting("Bing_ApiKey")))
                .ForMember(dest => dest.Culture, opt => opt.Ignore())
                .ForMember(dest => dest.UserMapView, opt => opt.Ignore())
                .ForMember(dest => dest.UserLocation, opt => opt.Ignore())
                .ForMember(dest => dest.UserRegion, opt => opt.Ignore())
                .ForMember(dest => dest.UserIp, opt => opt.Ignore());

            Mapper.CreateMap<BingMapsRESTToolkit.Location, Domain.Models.BingGeoCodeResponse>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Confidence, opt => opt.MapFrom(src => src.Confidence))
                .ForMember(dest => dest.EntityType, opt => opt.MapFrom(src => src.EntityType));

            Mapper.CreateMap<Domain.Models.ReverseGeocodeRequest, ReverseGeocodeRequest>()
                .ForMember(dest => dest.latlng, opt => opt.ResolveUsing<LocationsResolver>().FromMember(src => src.Location));

            Mapper.CreateMap<Domain.Models.GeocodeRequest, GeocodeRequest>()
                .ForMember(dest => dest.address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.language, opt => opt.MapFrom(src => src.Language.Code));

            Mapper.CreateMap<GeocodeResponse, Domain.Models.GeocodeResponse>()
                .ForMember(dest => dest.Results, opt => opt.MapFrom(src => src.results))
                .ForMember(dest => dest.Status, opt => opt.ResolveUsing<StatusResolver>().FromMember(src => src.status))
                .ForMember(dest => dest.ErrorMessage, opt => opt.MapFrom(src => src.error_message));

            Mapper.CreateMap<Address, Domain.Models.Address>()
                .ForMember(dest => dest.AddressComponents, opt => opt.MapFrom(src => src.address_components))
                .ForMember(dest => dest.FormattedAddress, opt => opt.MapFrom(src => src.formatted_address))
                .ForMember(dest => dest.Geometry, opt => opt.MapFrom(src => src.geometry))
                .ForMember(dest => dest.PlaceId, opt => opt.MapFrom(src => src.place_id))
                .ForMember(dest => dest.Types, opt => opt.MapFrom(src => src.types));

            Mapper.CreateMap<AddressComponent, Domain.Models.AddressComponent>()
                .ForMember(dest => dest.LongName, opt => opt.MapFrom(src => src.long_name))
                .ForMember(dest => dest.ShortName, opt => opt.MapFrom(src => src.short_name))
                .ForMember(dest => dest.Types, opt => opt.MapFrom(src => src.types));

            Mapper.CreateMap<Geometry, Domain.Models.Geometry>()
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.location))
                .ForMember(dest => dest.LocationType, opt => opt.MapFrom(src => src.location_type))
                .ForMember(dest => dest.Viewport, opt => opt.MapFrom(src => src.viewport));

            Mapper.CreateMap<Viewport, Domain.Models.Viewport>()
                .ForMember(dest => dest.NorthEast, opt => opt.MapFrom(src => src.northeast))
                .ForMember(dest => dest.SouthEast, opt => opt.MapFrom(src => src.southeast));
        }
    }
}