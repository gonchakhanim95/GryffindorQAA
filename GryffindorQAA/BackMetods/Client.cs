namespace GryffindorQAA.BackMetods
{
    public class Clientt
    {
        private const string HOST = "https://piter-education.ru:7070";
        public int Registration(RequestRegistrationModel model)
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

        public int CreateCourse(CourseRequestModel model, string token = null)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string jsonContent = JsonSerializer.Serialize(model); 
            HttpResponseMessage responseMessage = SendRequest(HttpMethod.Post, $"/api/Courses", jsonContent, authorizationToken: token);
            HttpStatusCode actuaLCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actuaLCode);
            CourseResponseModel responseBody = responseMessage.Content.ReadFromJsonAsync<CourseResponseModel>().Result;
            return responseBody.Id;
        }
        public int CreateGroup(GroupRequestModel model,string token = null)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string jsonContent = JsonSerializer.Serialize(model);
            HttpResponseMessage responseMessage = SendRequest(HttpMethod.Post, $"/api/Groups", jsonContent,authorizationToken: token);
            HttpStatusCode actuaLCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actuaLCode);
            GroupResponseModel responseBody = responseMessage.Content.ReadFromJsonAsync<GroupResponseModel>().Result;
            return responseBody.Id;
        }
        public void AddUserInGroup(int groupId, int userId, string role, string token = null)
        {
            HttpStatusCode expectedCode = HttpStatusCode.NoContent;
            HttpResponseMessage responseMessage = SendRequest(HttpMethod.Post, $"/api/Groups/{groupId}/user/{userId}/role/{role}", authorizationToken: token);
            HttpStatusCode actuaLCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actuaLCode);
        }
        public int CreateTaskAsTeacher(TaskRequestModel model, string token = null)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string jsonContent = JsonSerializer.Serialize(model);
            HttpResponseMessage responseMessage = SendRequest(HttpMethod.Post, $"/api/Tasks/teacher", jsonContent, authorizationToken: token);
            HttpStatusCode actuaLCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actuaLCode);
            TaskResponseModel responseBody = responseMessage.Content.ReadFromJsonAsync<TaskResponseModel>().Result;
            return responseBody.Id;
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
