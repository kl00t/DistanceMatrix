namespace DistanceMatrix.Kernel.Mappings
{
    using AutoMapper;

    public class DistanceMatrixMappings : Profile
    {
        /// <summary>
        /// The configure.
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<Connector.Entities.DistanceMatrix, Domain.Models.DistanceMatrixResponse>()
                .ForMember(dest => dest.Rows, opt => opt.MapFrom(src => src.rows))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.status))
                .ForMember(dest => dest.OriginAddresses, opt => opt.MapFrom(src => src.origin_addresses))
                .ForMember(dest => dest.DestinationAddresses, opt => opt.MapFrom(src => src.destination_addresses));

            Mapper.CreateMap<Connector.Entities.Row, Domain.Models.Row>()
                .ForMember(dest => dest.Rows, opt => opt.MapFrom(src => src.rows));

            Mapper.CreateMap<Connector.Entities.Element, Domain.Models.Element>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.status))
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.duration))
                .ForMember(dest => dest.Distance, opt => opt.MapFrom(src => src.distance));

            Mapper.CreateMap<Connector.Entities.Distance, Domain.Models.Distance>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.text))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value));

            Mapper.CreateMap<Connector.Entities.Duration, Domain.Models.Duration>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.text))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value));
        }
    }
}