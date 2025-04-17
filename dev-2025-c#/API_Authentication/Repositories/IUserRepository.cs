namespace API_Authentication
{
    public interface IUserRepository
    {
        User? GetEmailAndPassword(string email, string password);
    }
}

