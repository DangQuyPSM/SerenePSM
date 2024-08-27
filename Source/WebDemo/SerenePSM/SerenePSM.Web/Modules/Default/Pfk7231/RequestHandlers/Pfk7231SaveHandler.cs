using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7231Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7231Row;

namespace SerenePSM.Default;

public interface IPfk7231SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7231SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7231SaveHandler
{
    public Pfk7231SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}