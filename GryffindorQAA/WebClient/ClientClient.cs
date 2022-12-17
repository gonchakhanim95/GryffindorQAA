using GryffindorQAA.BackModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GryffindorQAA.Client
{
    public class ClientClient
    {
        public string Auth(AuthRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.OK;
            string json = JsonSerializer.Serialize<AuthRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/sign-in"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);

            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actualCode);

            string token = responseMessage.Content.ReadAsStringAsync().Result;

            return token;
        }

        public string RegistrationStudent(RegistrationRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<RegistrationRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/register"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actualCode);

            string userId =responseMessage.Content.ReadAsStringAsync().Result;
            return userId;

        }
        /* public List<UserResponseModel> GetUsers(string token)
         {
             HttpStatusCode expectedCode = HttpStatusCode.OK;

             HttpClientHandler clientHandler = new HttpClientHandler();
             clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

             HttpClient client = new HttpClient(clientHandler);
             client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

             HttpRequestMessage message = new HttpRequestMessage()
             {
                 Method = HttpMethod.Get,
                 RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Users"),
             };

             HttpResponseMessage responseMessage = client.Send(message);

             HttpStatusCode actualCode = responseMessage.StatusCode;
             Assert.Equal(expectedCode, actualCode);

             string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
             List<UserResponseModel> users = JsonSerializer.Deserialize<List<UserResponseModel>>(responseJson)!;

             return users;
         }*/
       
        public void GiveRoleTeacher (string token, string userId)
        {
            
            HttpStatusCode expectedCode = HttpStatusCode.NoContent;

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Add("Authorize", $"Bearer {token}");
            HttpRequestMessage message = new HttpRequestMessage()

            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Users/{userId}/role/Teacher/")
            };
            HttpResponseMessage responseMessage = client.Send(message);

            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actualCode);
        }
    }
}
