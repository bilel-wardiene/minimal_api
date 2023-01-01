using MinimalJwt.Models;
using MinimalJwt.Repositories;

namespace MinimalJwt.Services
{
    public class CapteurService : ICapteurService
    {
        public Capteur Create(Capteur capteur)
        {
            capteur.Id = CapteurRepository.capteurs.Count + 1;
            CapteurRepository.capteurs.Add(capteur);

            return capteur;
        }

        public Capteur Get(int id)
        {
            var capteur = CapteurRepository.capteurs.FirstOrDefault(o => o.Id == id);

            if (capteur is null) return null;

            return capteur;
        }

        public List<Capteur> List()
        {
            var capteurs = CapteurRepository.capteurs;

            return capteurs;
        }

        public Capteur Update(Capteur newCapteur)
        {
            var oldCapteur = CapteurRepository.capteurs.FirstOrDefault(o => o.Id == newCapteur.Id);

            if (oldCapteur is null) return null;

            oldCapteur.Temperature = newCapteur.Temperature;
            oldCapteur.Date = newCapteur.Date;
            

            return newCapteur;
        }

        public bool Delete(int id)
        {
            var oldCapteur = CapteurRepository.capteurs.FirstOrDefault(o => o.Id == id);

            if (oldCapteur is null) return false;

            CapteurRepository.capteurs.Remove(oldCapteur);

            return true;
        }
    }
}
