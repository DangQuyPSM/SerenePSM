using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Administration.LanguageRow;


namespace SerenePSM.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}