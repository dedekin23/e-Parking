namespace TubesKPL
{
    class UserTableDriven
    {
        public enum Username { users, althoof, iwiniwin, afanafan, michael};
        public static string[] password = { "users12345", "123456789", "iwiniwin1", "afanafan1", "michael12"};

        public static string getPassword(Username username)
        {
            return password[(int)username];
        }
    }
}
