using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers
{
    public class CreateCustomerHandler : 
        IRequestHandler<CreateCustomerRequest,CreateCustomerResponse >  //recebe, retorna
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //  verificar se cliente está cadastrado
            // valida os dados
            // insere cliente
            // envia email de boas vindas
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Gabriel dev2",
                Email = "dev2@wegen.com.br",
                Date = DateTime.Now,
            };
            return Task.FromResult(result);
        }
    }
}
