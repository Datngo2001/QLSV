using System.Drawing;

namespace QLSV
{
    public static class CurrentUser
    {
        public static string UserName { get; set; }
        public static int Id { get; set; }
        public static string fname { get; set; }
        public static string lname { get; set; }
        public static Image Avatar { get; set; }
        public static bool isAdmin { get; set; }
        public static bool isManager = false;
        public static bool isContact = true;
    }
}
