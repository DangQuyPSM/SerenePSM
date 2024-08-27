using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7171Row>;
using MyRow = SerenePSM.Default.Pfk7171Row;

namespace SerenePSM.Default;

public interface IPfk7171RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7171RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7171RetrieveHandler
{
    public Pfk7171RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}