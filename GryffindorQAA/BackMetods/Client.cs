namespace GryffindorQAA.BackMetods
{
    public class Clientt
    {
        private const string HOST = "https://piter-education.ru:7070";
        public int RegistrationStudent(RequestRegistrationModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize(model);
            HttpResponseMessage responseMessage = SendRequest(HttpMethod.Post, $"/register", json);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actualCode);
            var responseRegistrationModel = responseMessage.Content.ReadFromJsonAsync<ResponseRegistrationModel>().Result;
            return responseRegistrationModel.Id;
        }

        public string Auth(AuthRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.OK;
            string jsonContent = JsonSerializer.Serialize(model);
            HttpResponseMessage responseMessage = SendRequest(HttpMethod.Post, $"/sign-in", jsonContent);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actualCode);
            return responseMessage.Content.ReadAsStringAsync().Result;
        }

        public void GiveRole(string token, int id, string role)
        {
            HttpStatusCode expectedCode = HttpStatusCode.NoContent;
            HttpResponseMessage responseMessage = SendRequest(HttpMethod.Post, $"/api/Users/{id}/role/{role}", authorizationToken: token);
            HttpStatusCode actuaLCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actuaLCode);
        }

        private static HttpResponseMessage SendRequest(HttpMethod httpMethod, string url, string content = null, string authorizationToken = null)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = httpMethod,
                RequestUri = new Uri($"{HOST}{url}")
            };

            if (!string.IsNullOrWhiteSpace(content)) message.Content = new StringContent(content, Encoding.UTF8, "application/json");

            if (!string.IsNullOrWhiteSpace(authorizationToken)) client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authorizationToken);

            return client.Send(message);
        }
    }
}
