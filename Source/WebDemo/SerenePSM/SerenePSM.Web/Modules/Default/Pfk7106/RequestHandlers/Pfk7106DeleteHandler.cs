using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7106Row;

namespace SerenePSM.Default;

public interface IPfk7106DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7106DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7106DeleteHandler
{
    public Pfk7106DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}