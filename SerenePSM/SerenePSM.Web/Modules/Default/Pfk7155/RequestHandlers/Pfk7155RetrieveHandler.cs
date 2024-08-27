using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7155Row>;
using MyRow = SerenePSM.Default.Pfk7155Row;

namespace SerenePSM.Default;

public interface IPfk7155RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7155RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7155RetrieveHandler
{
    public Pfk7155RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}