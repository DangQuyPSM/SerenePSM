using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7105Row>;
using MyRow = SerenePSM.Default.Pfk7105Row;

namespace SerenePSM.Default;

public interface IPfk7105ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7105ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7105ListHandler
{
    public Pfk7105ListHandler(IRequestContext context)
            : base(context)
    {
    }
}