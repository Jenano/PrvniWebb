using treninkovyDenik.Model;

namespace treninkovyDenik.Logic.Uzivatel
{
    public interface IUzivatelService
    {
        IEnumerable< Uzivatel > GetActivities();
    }
}
