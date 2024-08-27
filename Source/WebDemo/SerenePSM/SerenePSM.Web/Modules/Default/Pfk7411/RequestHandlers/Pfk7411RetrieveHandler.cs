using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7411Row>;
using MyRow = SerenePSM.Default.Pfk7411Row;

namespace SerenePSM.Default;

public interface IPfk7411RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7411RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7411RetrieveHandler
{
    public Pfk7411RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}