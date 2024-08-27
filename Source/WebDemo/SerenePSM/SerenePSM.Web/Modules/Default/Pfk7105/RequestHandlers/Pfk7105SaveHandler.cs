using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7105Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7105Row;

namespace SerenePSM.Default;

public interface IPfk7105SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7105SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7105SaveHandler
{
    public Pfk7105SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}