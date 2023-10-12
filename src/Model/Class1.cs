
namespace Model
{
    public class MyNetworkClient : IDisposable
    {
        private HttpClient _client;

        public MyNetworkClient()
        {
            _client = new HttpClient();
        }

        public void Dispose() 
        {
            _client.Dispose();
        }
    }
}
