using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppWPFProject.Model.Data.Entities
{
    public class PostData //отправка значений в базу данных
    {
        private HttpClient _httpClient;

        public PostData(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task PostReviev(Reviev revievData)
        {
            string jsonDataReviev = JsonParser<Reviev>.Serialized(revievData);

            HttpContent content = new StringContent(jsonDataReviev);

            HttpResponseMessage responseToReviev = await _httpClient.PostAsync($"http://192.168.10.167:8080/User", content);

            if (responseToReviev.IsSuccessStatusCode)
            {
                string responseContent = await responseToReviev.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);
            }

        }

        public async Task PostUser(User userData) //!!!!!!!!!!
        {
            string jsonDataUser = JsonParser<User>.Serialized(userData);

            HttpContent content = new StringContent(jsonDataUser);

            HttpResponseMessage responseToUsers = await _httpClient.PostAsync($"http://192.168.10.167:8080/User", content);

            if (responseToUsers.IsSuccessStatusCode)
            {
                string responseContent = await responseToUsers.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);
            }
        }

        public async Task PostCity(City cityData)
        {
            string jsonDataCity = JsonParser<City>.Serialized(cityData);

            HttpContent content = new StringContent(jsonDataCity);

            HttpResponseMessage responseToCitys = await _httpClient.PostAsync($"http://192.168.10.167:8080/City", content);

            if (responseToCitys.IsSuccessStatusCode)
            {
                string responseContent = await responseToCitys.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);
            }
        }

        public async Task PostHouse(House houseData)
        {
            string jsonDataHouse = JsonParser<House>.Serialized(houseData);

            HttpContent content = new StringContent(jsonDataHouse);

            HttpResponseMessage responseToHouse = await _httpClient.PostAsync($"http://192.168.10.167:8080/City", content);

            if (responseToHouse.IsSuccessStatusCode)
            {
                string responseContent = await responseToHouse.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);
            }

        }

        public async Task PostStreet(Street streetData)
        {
            string jsonDataStreet = JsonParser<Street>.Serialized(streetData);

            HttpContent content = new StringContent(jsonDataStreet);

            HttpResponseMessage responseToStreet = await _httpClient.PostAsync($"http://192.168.10.167:8080/Street", content);

            if (responseToStreet.IsSuccessStatusCode)
            {
                string responseContent = await responseToStreet.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);
            }


        }
    }
}
