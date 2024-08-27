using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7104Row;

namespace SerenePSM.Default;

public interface IPfk7104DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7104DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7104DeleteHandler
{
    public Pfk7104DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}