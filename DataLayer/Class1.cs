using Entity;

namespace DataLayer;
public class DataAccess
{
    public static List<Movies> movies = new List<Movies>()
    {
        new Movies{Id=1, Name="Toofan",Ryear=2021,Rating=3},
        new Movies{Id=2, Name="Ludo",Ryear=2020,Rating=4},
        new Movies{Id=3, Name="Gunjan",Ryear=2020,Rating=1},
        new Movies{Id=4, Name="Big Bull",Ryear=2022,Rating=3},
        new Movies{Id=5, Name="Laxmi",Ryear=2020,Rating=2}
    };

    public  List<Movies> GetMovies()
    {
        return movies;
    }
}
