using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7411Row;

namespace SerenePSM.Default;

public interface IPfk7411DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7411DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7411DeleteHandler
{
    public Pfk7411DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}