using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7411Row>;
using MyRow = SerenePSM.Default.Pfk7411Row;

namespace SerenePSM.Default;

public interface IPfk7411ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7411ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7411ListHandler
{
    public Pfk7411ListHandler(IRequestContext context)
            : base(context)
    {
    }
}