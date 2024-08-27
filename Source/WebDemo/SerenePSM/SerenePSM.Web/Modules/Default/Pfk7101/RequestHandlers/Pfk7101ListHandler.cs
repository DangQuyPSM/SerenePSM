using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7101Row>;
using MyRow = SerenePSM.Default.Pfk7101Row;

namespace SerenePSM.Default;

public interface IPfk7101ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7101ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7101ListHandler
{
    public Pfk7101ListHandler(IRequestContext context)
            : base(context)
    {
    }
}