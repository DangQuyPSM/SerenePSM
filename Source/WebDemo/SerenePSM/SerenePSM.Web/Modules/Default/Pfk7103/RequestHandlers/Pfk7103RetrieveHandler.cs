using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7103Row>;
using MyRow = SerenePSM.Default.Pfk7103Row;

namespace SerenePSM.Default;

public interface IPfk7103RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7103RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7103RetrieveHandler
{
    public Pfk7103RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}