using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppWPFProject.Model.Data.Entities
{
    public class GetData //получение данных о рейтинге дома из базы данных и передача их клиенту по HTTP
    {
        private HttpClient _httpClient;

        public GetData(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetReviev()
        {
            string reviev = string.Empty;

            List<Reviev> revievs = new();

            HttpResponseMessage responseToRevievs = await _httpClient.GetAsync($"http://192.168.10.167:8080/Reviev");
            if (responseToRevievs.IsSuccessStatusCode)
            {
                reviev = await responseToRevievs.Content.ReadAsStringAsync();
                revievs = JsonParser<List<Reviev>>.Deserialized(reviev);

                foreach (var item in revievs)
                {
                    Console.WriteLine(item.Description);
                }
            }
            return reviev;
        }

        public async Task<string> GetUser()
        {
            string user = string.Empty;

            List<User> users = new();

            HttpResponseMessage responseToUsers = await _httpClient.GetAsync($"http://192.168.10.167:8080/User");
            if (responseToUsers.IsSuccessStatusCode)
            {
                user = await responseToUsers.Content.ReadAsStringAsync();
                users = JsonParser<List<User>>.Deserialized(user);

                foreach (var item in users)
                {
                    Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.SurName + "\t" + item.Age);
                }
            }

            return user;
        }

        public async Task<string> GetCity()
        {
            string city = string.Empty;

            List<City> citys = new();

            HttpResponseMessage responseToCitys = await _httpClient.GetAsync($"http://192.168.10.167:8080/City");
            if (responseToCitys.IsSuccessStatusCode)
            {
                city = await responseToCitys.Content.ReadAsStringAsync();
                citys = JsonParser<List<City>>.Deserialized(city);

                foreach (var item in citys)
                {
                    Console.WriteLine(item.Name);
                }
            }

            return city;
        }

        public async Task<string> GetHouse()
        {
            string house = string.Empty;

            List<House> houses = new();

            HttpResponseMessage responseToHouses = await _httpClient.GetAsync($"http://192.168.10.167:8080/House");
            if (responseToHouses.IsSuccessStatusCode)
            {
                house = await responseToHouses.Content.ReadAsStringAsync();
                houses = JsonParser<List<House>>.Deserialized(house);

                foreach (var item in houses)
                {
                    Console.WriteLine(item.Name);
                }

            }

            return house;
        }

        public async Task<string> GetStreet()
        {
            string street = string.Empty;

            List<Street> streets = new();

            HttpResponseMessage responseToStreets = await _httpClient.GetAsync($"http://192.168.10.167:8080/Street");
            if (responseToStreets.IsSuccessStatusCode)
            {
                street = await responseToStreets.Content.ReadAsStringAsync();
                streets = JsonParser<List<Street>>.Deserialized(street);

                foreach (var item in streets)
                {
                    Console.WriteLine(item.Name);
                }
            }

            return street;
        }
    }
}
