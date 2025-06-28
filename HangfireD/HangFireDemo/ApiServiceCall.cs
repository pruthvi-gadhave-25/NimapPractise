namespace HangFireDemo
{
    public class ApiServiceCall
    {
        private readonly HttpClient _httpClient;
        public ApiServiceCall(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CallApiEndpointAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://localhost:7043/api/HangFireDemo");
                response.EnsureSuccessStatusCode();
                Console.WriteLine("API call succeeded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API call failed: {ex.Message}");
                throw;
            }

        }
    }
}
