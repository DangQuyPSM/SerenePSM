using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7155Row>;
using MyRow = SerenePSM.Default.Pfk7155Row;

namespace SerenePSM.Default;

public interface IPfk7155ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7155ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7155ListHandler
{
    public Pfk7155ListHandler(IRequestContext context)
            : base(context)
    {
    }
}