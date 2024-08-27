using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenePSM.Default.Pfk7231Row>;
using MyRow = SerenePSM.Default.Pfk7231Row;

namespace SerenePSM.Default;

public interface IPfk7231RetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7231RetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7231RetrieveHandler
{
    public Pfk7231RetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}