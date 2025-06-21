using MediatR;

namespace MediaterExample.Med.Queries
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
    {
        public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var products = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Pikachu",
                Quantity = 5,
                Amount = 1500.00m
            };

            var products2 = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Naruto",
                Quantity = 10,
                Amount = 100.50m
            };
            
            return Task.FromResult(new List<GetProductViewModel> { products, products2 });

           
        }
    }
}
