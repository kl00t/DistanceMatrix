namespace DistanceMatrix.Kernel.Mappings
{
    using AutoMapper;
    using Resolvers;

    public class DistanceMatrixMappings : Profile
    {
        /// <summary>
        /// The configure.
        /// </summary>
        protected override void Configure()
        {
			Mapper.CreateMap<Domain.Models.DistanceMatrixRequest, Domain.Models.RequestHistory>()
				.ForMember(dest => dest.Request, opt => opt.MapFrom(src => src))
				.ForMember(dest => dest.Id, opt => opt.Ignore());

			Mapper.CreateMap<Domain.Models.DistanceMatrixRequest, Connector.Entities.DistanceMatrixRequest>()
				.ForMember(dest => dest.origins, opt => opt.MapFrom(src => src.Origin))
				.ForMember(dest => dest.destinations, opt => opt.MapFrom(src => src.Destination))
				.ForMember(dest => dest.mode, opt => opt.MapFrom(src => src.Mode))
				.ForMember(dest => dest.units, opt => opt.MapFrom(src => src.Units))
				.ForMember(dest => dest.key, opt => opt.Ignore())
                .ForMember(dest => dest.language, opt => opt.Ignore())
                .ForMember(dest => dest.avoid, opt => opt.Ignore())
                .ForMember(dest => dest.arrival_time, opt => opt.Ignore())
                .ForMember(dest => dest.departure_time, opt => opt.Ignore())
                .ForMember(dest => dest.traffic_model, opt => opt.Ignore())
                .ForMember(dest => dest.transit_mode, opt => opt.Ignore())
                .ForMember(dest => dest.transit_routing_preference, opt => opt.Ignore());

            Mapper.CreateMap<Connector.Entities.DistanceMatrixResponse, Domain.Models.DistanceMatrixResponse>()
                .ForMember(dest => dest.Rows, opt => opt.MapFrom(src => src.rows))
                .ForMember(dest => dest.Status, opt => opt.ResolveUsing<StatusResolver>().FromMember(src => src.status))
                .ForMember(dest => dest.ErrorMessage, opt => opt.MapFrom(src => src.error_message))
                .ForMember(dest => dest.OriginAddresses, opt => opt.MapFrom(src => src.origin_addresses))
                .ForMember(dest => dest.DestinationAddresses, opt => opt.MapFrom(src => src.destination_addresses));

            Mapper.CreateMap<Connector.Entities.Row, Domain.Models.Row>()
                .ForMember(dest => dest.Elements, opt => opt.MapFrom(src => src.elements));

            Mapper.CreateMap<Connector.Entities.Element, Domain.Models.Element>()
                .ForMember(dest => dest.Status, opt => opt.ResolveUsing<ElementStatusResolver>().FromMember(src => src.status))
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.duration))
                .ForMember(dest => dest.Distance, opt => opt.MapFrom(src => src.distance))
                .ForMember(dest => dest.Fare, opt => opt.MapFrom(src => src.fare));

            Mapper.CreateMap<Connector.Entities.Distance, Domain.Models.Distance>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.text))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value));

            Mapper.CreateMap<Connector.Entities.Duration, Domain.Models.Duration>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.text))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value));

            Mapper.CreateMap<Connector.Entities.Fare, Domain.Models.Fare>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.text))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.currency));
        }
    }
}