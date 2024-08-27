using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7121Row;

namespace SerenePSM.Default;

public interface IPfk7121DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7121DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7121DeleteHandler
{
    public Pfk7121DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}