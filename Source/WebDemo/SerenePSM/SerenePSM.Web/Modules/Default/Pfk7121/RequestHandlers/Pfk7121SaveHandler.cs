using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7121Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7121Row;

namespace SerenePSM.Default;

public interface IPfk7121SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7121SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7121SaveHandler
{
    public Pfk7121SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}