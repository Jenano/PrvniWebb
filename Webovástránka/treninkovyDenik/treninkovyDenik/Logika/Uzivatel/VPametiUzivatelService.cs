using treninkovyDenik.Model;


namespace treninkovyDenik.Logika.Uzivatel
{
    public class VPametiUzivatelService : UzivatelService 
    {
        public VPametiUzivatelService()
        {

        }

        public IEnumerable<Uzivatel> GetActivities()
        {
            return new[] { new Uzivatel() { Name = "Neznámé" }};
        }
    }
}
