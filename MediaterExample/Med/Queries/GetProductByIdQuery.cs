using MediatR;

namespace MediaterExample.Med.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }

    }
}
