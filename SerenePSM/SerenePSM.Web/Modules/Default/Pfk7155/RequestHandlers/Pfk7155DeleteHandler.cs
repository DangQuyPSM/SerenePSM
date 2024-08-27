using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7155Row;

namespace SerenePSM.Default;

public interface IPfk7155DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7155DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7155DeleteHandler
{
    public Pfk7155DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}