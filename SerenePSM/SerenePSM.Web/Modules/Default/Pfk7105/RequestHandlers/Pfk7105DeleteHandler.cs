using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7105Row;

namespace SerenePSM.Default;

public interface IPfk7105DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7105DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7105DeleteHandler
{
    public Pfk7105DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}