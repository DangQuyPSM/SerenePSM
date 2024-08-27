using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7101Row>;
using MyRow = SerenePSM.Default.Pfk7101Row;

namespace SerenePSM.Default;

public interface IPfk7101RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7101RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7101RetrieveHandler
{
    public Pfk7101RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}