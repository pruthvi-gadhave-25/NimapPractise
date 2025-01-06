using System.Text;
using System.Net.Http.Headers;
    
        HttpClient client = new HttpClient();

            // Set the base address of the API.
            client.BaseAddress = new Uri("https://localhost:7202");

            // Clear any previously set request headers.
            client.DefaultRequestHeaders.Accept.Clear();

            // Add JSON to the Accept header to tell the server to send data in JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));




            ///Basic Authentication here ---------------------------------
            ///

            var byteArray = Encoding.ASCII.GetBytes("Pranaya:Test@1234");//// Encoding the username and password as ASCII.

            client.DefaultRequestHeaders.Authorization = new
                AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray)) ;






            try
            {
                // Perform a GET request to retrieve all users.
                Console.WriteLine("Getting all users...");
                var users = await  GetAsync("api/users");
                Console.WriteLine(users);
               
            }
            catch (Exception e)
            {
                // Output any exceptions to the console.
                Console.WriteLine(e.Message);
            }


          
    

           async Task<string>GetAsync(string path )
        {
            HttpResponseMessage response = await client.GetAsync(path);
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : $"Error: {response.StatusCode}";
        }


    

