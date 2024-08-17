using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7101Row;

namespace SerenePSM.Default;

public interface IPfk7101DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7101DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7101DeleteHandler
{
    public Pfk7101DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}