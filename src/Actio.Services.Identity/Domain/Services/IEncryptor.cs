namespace Actio.Services.Identity.Domain.Services
{
    public interface IEncryptor
    {
         string GetSalt(string value);

         string GetHash(string value, string salt);
    }
}