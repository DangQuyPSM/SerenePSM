using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7231Row>;
using MyRow = SerenePSM.Default.Pfk7231Row;

namespace SerenePSM.Default;

public interface IPfk7231ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7231ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7231ListHandler
{
    public Pfk7231ListHandler(IRequestContext context)
            : base(context)
    {
    }
}