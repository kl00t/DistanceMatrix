namespace Travel.Api.Kernel.Mappings
{
    using AutoMapper;
    using Connector;
    using Connector.Entities;
    using Resolvers;

    public class DirectionsMappings : Profile
	{
		protected override void Configure()
		{
		    Mapper.CreateMap<Domain.Models.DirectionsRequest, DirectionsRequest>()
		        .ForMember(dest => dest.origin, opt => opt.MapFrom(src => src.Origin))
		        .ForMember(dest => dest.destination, opt => opt.MapFrom(src => src.Destination))
		        .ForMember(dest => dest.mode, opt => opt.MapFrom(src => src.Mode))
		        .ForMember(dest => dest.key, opt => opt.UseValue(ConfigurationHelper.GetAppSetting("Directions_ApiKey")));

            Mapper.CreateMap<DirectionsResponse, Domain.Models.DirectionsResponse>()
				.ForMember(dest => dest.GeocodedWaypoints, opt => opt.MapFrom(src => src.geocoded_waypoints))
				.ForMember(dest => dest.Routes, opt => opt.MapFrom(src => src.routes))
				.ForMember(dest => dest.Status, opt => opt.ResolveUsing<StatusResolver>().FromMember(src => src.status))
				.ForMember(dest => dest.ErrorMessage, opt => opt.MapFrom(src => src.error_message));

			Mapper.CreateMap<GeocodedWaypoint, Domain.Models.GeocodedWaypoint>()
                .ForMember(dest => dest.GeocoderStatus, opt => opt.MapFrom(src => src.geocoder_status))
                .ForMember(dest => dest.PartialMatch, opt => opt.MapFrom(src => src.partial_match))
                .ForMember(dest => dest.PlaceId, opt => opt.MapFrom(src => src.place_id))
                .ForMember(dest => dest.Types, opt => opt.MapFrom(src => src.types));

		    Mapper.CreateMap<Route, Domain.Models.Route>();
		}
	}
}