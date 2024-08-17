namespace SerenePSM.Modules.Default.Movie;

[EnumKey("MovieDB.MovieKind")]
public enum MovieKind
{
    [Description("Film")]
    Film = 1,
    [Description("TV Series")]
    TvSeries = 2,
    [Description("Mini Series")]
    MiniSeries = 3
}
