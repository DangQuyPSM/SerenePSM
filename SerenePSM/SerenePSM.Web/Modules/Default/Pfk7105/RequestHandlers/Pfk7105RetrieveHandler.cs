using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7105Row>;
using MyRow = SerenePSM.Default.Pfk7105Row;

namespace SerenePSM.Default;

public interface IPfk7105RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7105RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7105RetrieveHandler
{
    public Pfk7105RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}