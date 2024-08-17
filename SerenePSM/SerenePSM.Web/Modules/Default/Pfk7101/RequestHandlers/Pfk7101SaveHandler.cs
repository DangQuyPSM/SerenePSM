using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7101Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7101Row;

namespace SerenePSM.Default;

public interface IPfk7101SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7101SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7101SaveHandler
{
    public Pfk7101SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}