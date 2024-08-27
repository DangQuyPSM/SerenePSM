using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7121Row>;
using MyRow = SerenePSM.Default.Pfk7121Row;

namespace SerenePSM.Default;

public interface IPfk7121ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7121ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7121ListHandler
{
    public Pfk7121ListHandler(IRequestContext context)
            : base(context)
    {
    }
}