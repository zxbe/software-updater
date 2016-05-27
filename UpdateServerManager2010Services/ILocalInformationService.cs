namespace UpdateServerManager2010Services
{
    public interface ILocalInformationService
    {
        string GenerateLocalInformation(string servername, string executable, string serverpath, string httpsUser, string httpsPwd, string proxyUrl, string proxyHttpsPort, string proxyUser, string proxyPwd);
    }
}