using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7155Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7155Row;

namespace SerenePSM.Default;

public interface IPfk7155SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7155SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7155SaveHandler
{
    public Pfk7155SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}