using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.GenreRow;

namespace SerenePSM.Default;

public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
{
    public GenreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}