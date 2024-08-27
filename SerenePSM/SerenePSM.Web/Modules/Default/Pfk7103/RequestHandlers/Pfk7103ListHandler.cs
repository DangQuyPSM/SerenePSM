using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7103Row>;
using MyRow = SerenePSM.Default.Pfk7103Row;

namespace SerenePSM.Default;

public interface IPfk7103ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7103ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7103ListHandler
{
    public Pfk7103ListHandler(IRequestContext context)
            : base(context)
    {
    }
}