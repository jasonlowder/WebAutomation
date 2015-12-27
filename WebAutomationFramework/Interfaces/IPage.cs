namespace WebAutomationFramework.Interfaces
{
    public interface IPage
    {
        Browser Browser { get; set; }
        void GoTo(int attempt = 0);
    }
}
