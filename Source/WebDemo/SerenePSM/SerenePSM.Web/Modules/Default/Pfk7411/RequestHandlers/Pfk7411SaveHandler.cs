using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7411Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7411Row;

namespace SerenePSM.Default;

public interface IPfk7411SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7411SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7411SaveHandler
{
    public Pfk7411SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}