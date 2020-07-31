namespace JMRLeague.Shared.Services
{
    public abstract class ConfigurableService
    {
        protected AppSettings Settings;

        protected string RoutePrefix => Settings != null ? Settings.ServiceUrl : string.Empty;
    }
}
