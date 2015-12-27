using WebAutomationFramework;

namespace Chase
{
    public class User : UserBase
    {
        public static User Chase { get { return new User { UserName = "", Password = "" }; } }
    }
}
