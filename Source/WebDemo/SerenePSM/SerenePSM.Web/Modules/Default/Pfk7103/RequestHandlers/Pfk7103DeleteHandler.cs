using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7103Row;

namespace SerenePSM.Default;

public interface IPfk7103DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7103DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7103DeleteHandler
{
    public Pfk7103DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}