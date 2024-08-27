using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7106Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7106Row;

namespace SerenePSM.Default;

public interface IPfk7106SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7106SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7106SaveHandler
{
    public Pfk7106SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}