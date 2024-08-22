using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7231Row;

namespace SerenePSM.Default;

public interface IPfk7231DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7231DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7231DeleteHandler
{
    public Pfk7231DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}