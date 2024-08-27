using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7106Row>;
using MyRow = SerenePSM.Default.Pfk7106Row;

namespace SerenePSM.Default;

public interface IPfk7106ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7106ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7106ListHandler
{
    public Pfk7106ListHandler(IRequestContext context)
            : base(context)
    {
    }
}