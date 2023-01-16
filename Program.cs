namespace Algoritms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users.Add(new User("savva123","Savva",true));
            users.Add(new User("irma123", "Irma", false));
            users.Add(new User("vanya123", "Ivan", false));

            foreach (var user in users)
            {
                user.Greetings(user.Name);

                if (!user.IsPremium)
                {
                    Ads.ShowAds();
                }
            }
        }
    }
}