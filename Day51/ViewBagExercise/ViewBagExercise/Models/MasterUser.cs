namespace ViewBagExercise.Models
{
    public class MasterUser
    {
        public AppUser GetUser(string username)
        {
            AppUser appUser = new AppUser
            {
                UserName = username,
            };
            return appUser;
        }

    }
}