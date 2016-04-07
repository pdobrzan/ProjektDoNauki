using AutoMapper;
using Website.DataAccess.Models;
using Website.DataTransferObjects.Models;
using Website.Mapper.Interfaces;

namespace Website.Mapper.Services
{
    public class MapperService : IMapperService
    {
        private MapperConfiguration configuration;

        public MapperService()
        {
            this.configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CarAuction, CarAuctionDto>().ReverseMap();
            });

            var mapper = configuration.CreateMapper();
        }

        public TTo Map<TTo>(object source)
        {
            var mapper = configuration.CreateMapper();
            return mapper.Map<TTo>(source);
        }
    }
}