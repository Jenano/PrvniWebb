using treninkovyDenik.Model;

namespace treninkovyDenik.Logic.Uzivatel
{
    public interface IUzivatel
    {
        IEnumerable< Uzivatel > GetActivities();
    }
}

