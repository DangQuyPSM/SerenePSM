using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7103Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7103Row;

namespace SerenePSM.Default;

public interface IPfk7103SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7103SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7103SaveHandler
{
    public Pfk7103SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}