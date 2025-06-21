using MediatR;

namespace MediaterExample.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductViewModel
            {
                Id = Guid.NewGuid(), 
                Name = "Naruto",
                Quantity = 10,
                Amount = 100.50m
            };

            return Task.FromResult(viewModel);
        }
    }
}
