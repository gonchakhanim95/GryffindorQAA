﻿using GryffindorQAA.BackModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GryffindorQAA.Client
{
    public class Client
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
                RequestUri = new System.Uri($"https://piter-education.ru:7070/register"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);

            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.Equal(expectedCode, actualCode);

            string token = responseMessage.Content.ReadAsStringAsync().Result;

            return token;
        }

        public int RegistrationStudent(RegistrationRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<RegistrationRequestModel>(model);

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

            int Id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);
            return Id;

        }


    }
}
