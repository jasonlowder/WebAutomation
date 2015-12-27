using WebAutomationFramework.Factories;
using WebAutomationFramework.Interfaces;

namespace WebAutomationFramework
{
    public abstract class PagesBase
    {
        protected static T GetPage<T>() where T : IPage, new()
        {
            var page = new T();
            PageFactory.InitElements(page);
            return page;
        }
    }
}
