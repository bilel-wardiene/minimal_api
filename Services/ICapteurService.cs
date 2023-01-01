using MinimalJwt.Models;

namespace MinimalJwt.Services
{
    public interface ICapteurService
    {
        public Capteur Create(Capteur capteur);
        public Capteur Get(int id);
        public List<Capteur> List();
        public Capteur Update(Capteur capteur);
        public bool Delete(int id);
    }
}
