using Discount.Grpc.Protos;

namespace Basket.API.GrpsServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProto;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProto)
        {
            _discountProto = discountProto;
        }

        public async Task<CouponModel> GetDiscount(string productName) 
        {
            var discountRequest = new GetDiscountRequest { ProductName = productName };

            return await _discountProto.GetDiscountAsync(discountRequest);
        }
    }
}
