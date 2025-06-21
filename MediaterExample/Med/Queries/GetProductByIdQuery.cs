using MediatR;

namespace MediaterExample.Med.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductByIdViewModel>
    {
        public Guid Id { get; set; }

    }
}
