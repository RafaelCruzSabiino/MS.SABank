namespace SABank.Interfaces.Outbound
{
    public interface ILoggerAdapter<T>
    {
        public void LogError(string error);
        public void LogWarning(string warning);
        public void LogInformation(string information);
    }
}