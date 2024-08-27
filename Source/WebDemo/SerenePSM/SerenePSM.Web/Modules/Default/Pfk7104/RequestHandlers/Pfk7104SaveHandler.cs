using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7104Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7104Row;

namespace SerenePSM.Default;

public interface IPfk7104SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7104SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7104SaveHandler
{
    public Pfk7104SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}