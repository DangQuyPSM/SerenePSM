using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7121Row>;
using MyRow = SerenePSM.Default.Pfk7121Row;

namespace SerenePSM.Default;

public interface IPfk7121RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7121RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7121RetrieveHandler
{
    public Pfk7121RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}