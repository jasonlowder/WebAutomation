using WebAutomationFramework;

namespace Wellsfargo
{
    public class User : UserBase
    {
        public static User Wellsfargo{ get { return new User {UserName = "", Password = ""}; }}
    }
}
