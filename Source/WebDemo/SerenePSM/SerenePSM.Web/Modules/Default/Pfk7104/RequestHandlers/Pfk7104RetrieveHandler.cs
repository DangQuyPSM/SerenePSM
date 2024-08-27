using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7104Row>;
using MyRow = SerenePSM.Default.Pfk7104Row;

namespace SerenePSM.Default;

public interface IPfk7104RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7104RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7104RetrieveHandler
{
    public Pfk7104RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}