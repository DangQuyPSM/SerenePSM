using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Default.Pfk7171Row>;
using MyRow = SerenePSM.Default.Pfk7171Row;

namespace SerenePSM.Default;

public interface IPfk7171ListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7171ListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7171ListHandler
{
    public Pfk7171ListHandler(IRequestContext context)
            : base(context)
    {
    }
}