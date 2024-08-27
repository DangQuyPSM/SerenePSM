using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7104Row>;
using MyRow = SerenePSM.Default.Pfk7104Row;

namespace SerenePSM.Default;

public interface IPfk7104ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7104ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7104ListHandler
{
    public Pfk7104ListHandler(IRequestContext context)
            : base(context)
    {
    }
}