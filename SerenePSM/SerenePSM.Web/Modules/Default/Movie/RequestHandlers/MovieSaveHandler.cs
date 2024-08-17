using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SerenePSM.Default.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenePSM.Default.MovieRow;

namespace SerenePSM.Default;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    public MovieSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}