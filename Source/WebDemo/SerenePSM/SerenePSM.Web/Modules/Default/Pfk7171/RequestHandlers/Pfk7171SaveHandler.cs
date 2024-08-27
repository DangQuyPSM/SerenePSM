using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.Pfk7171Row>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.Pfk7171Row;

namespace SerenePSM.Default;

public interface IPfk7171SaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class Pfk7171SaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPfk7171SaveHandler
{
    public Pfk7171SaveHandler(IRequestContext context)
            : base(context)
    {
    }
}