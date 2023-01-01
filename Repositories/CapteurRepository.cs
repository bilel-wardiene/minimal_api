using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class CapteurRepository
    {
        public static List<Capteur> capteurs = new()
        {
            new() { Id = 1, Temperature= 24, Date = DateTime.Now },
            new() { Id = 2, Temperature = 45, Date = DateTime.Now },
            new() { Id = 3, Temperature = 32, Date= DateTime.Now },
            new() { Id = 4, Temperature = 12, Date = DateTime.Now },
            new() { Id = 5, Temperature = 14, Date = DateTime.Now },
        };
    }
}
