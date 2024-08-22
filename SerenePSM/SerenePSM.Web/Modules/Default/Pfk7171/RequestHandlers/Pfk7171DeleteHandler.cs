using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenePSM.Default.Pfk7171Row;

namespace SerenePSM.Default;

public interface IPfk7171DeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7171DeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7171DeleteHandler
{
    public Pfk7171DeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}