using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "wissal_admin", EmailAddress = "wissal.admin@email.com", Password = "MyPass_w0rd", GivenName = "wissal", Surname = "chebbi", Role = "Administrator" },
            new() { Username = "bilel_standard", EmailAddress = "bilel.standard@email.com", Password = "MyPass_w0rd", GivenName = "bilel", Surname = "wardiene", Role = "Standard" },
        };
    }
}
