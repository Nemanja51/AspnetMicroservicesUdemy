using AutoMapper;
using Basket.API.Enitites;
using EventBus.Messages.Events;

namespace Basket.API.Mapper
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketCheckout, BaskerCheckoutEvent>().ReverseMap();

        }
    }
}
