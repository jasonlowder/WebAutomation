namespace WebAutomationFramework.Interfaces
{
    public interface IPage
    {
        IBrowser Browser { get; set; }
        void GoTo(int attempt = 0);
    }
}
