using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7106Row>;
using MyRow = SerenePSM.Default.Pfk7106Row;

namespace SerenePSM.Default;

public interface IPfk7106RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7106RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7106RetrieveHandler
{
    public Pfk7106RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}