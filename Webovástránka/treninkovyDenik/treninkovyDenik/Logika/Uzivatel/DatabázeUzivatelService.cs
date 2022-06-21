using treninkovyDenik.Logika.Uzivatel;

namespace treninkovyDenik.Logika.Uzivatel
{
    public class DatabázeUzivatelService: IUzivatelService
    {
        public IEnumerable< Uzivatel> GetActivities()
        {
            return new[] { new Uzivatel() { Name = "Nevíme"} };
        }
    }
}
