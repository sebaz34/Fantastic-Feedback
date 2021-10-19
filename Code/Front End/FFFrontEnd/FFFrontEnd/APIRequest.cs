using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Net.Http;

namespace FFFrontEnd
{
    public static class APIRequest<T>
    {

        /// <summary>
        /// Sends HTTP GET request to location specified in "_client" with directory of "apiController" at database position "id".
        /// </summary>
        /// <param name="_client"></param>
        /// <param name="apiController"></param>
        /// <param name="id"></param>
        /// <returns>
        /// Single record of specified type from database.
        /// </returns>
        public static T GetSingleRecord(HttpClient _client, string apiController, int id, string username)
        {
            HttpResponseMessage singleRecordResponse = _client.GetAsync($"{apiController}/{username}/{id}").Result;

            //Used to ensure that response is valid - useful for debugging
            singleRecordResponse.EnsureSuccessStatusCode();

            return singleRecordResponse.Content.ReadAsAsync<T>().Result;
        }

        /// <summary>
        /// Sends HTTP GET request to location specified in "_client" with directory of "apiController" 
        /// </summary>
        /// <param name="_client"></param>
        /// <param name="apiController"></param>
        /// <returns>
        /// All records available of specified type from database
        /// </returns>
        public static IEnumerable<T> GetAllRecord(HttpClient _client, string apiController, string username)
        {
            HttpResponseMessage allRecordResponse = _client.GetAsync($"{apiController}/{username}").Result;

            //Used to ensure that response is valid - useful for debugging
            try
            {
                allRecordResponse.EnsureSuccessStatusCode();
                return allRecordResponse.Content.ReadAsAsync<IEnumerable<T>>().Result;
            }
            catch (System.Exception)
            {
                return allRecordResponse.StatusCode as IEnumerable<T>;
            }

            
        }

        /// <summary>
        /// Sends HTTP POST request to post object "entity" at location specified in "_client" with directory of "apiController"
        /// </summary>
        /// <param name="_client"></param>
        /// <param name="apiController"></param>
        /// <param name="entity"></param>
        /// <returns>
        /// Object recieved in response code
        /// </returns>
        public static T PostRecord(HttpClient _client, string apiController, T entity)
        {
            HttpResponseMessage postRecordResponse = _client.PostAsJsonAsync(apiController, entity).Result;

            //Used to ensure that response is valid - useful for debugging
            postRecordResponse.EnsureSuccessStatusCode();

            return postRecordResponse.Content.ReadAsAsync<T>().Result;
        }

        /// <summary>
        /// Sends HTTP PUT request to place object "entity" at location "id" in database located at "_client" with directory of "apiController"
        /// </summary>
        /// <param name="_client"></param>
        /// <param name="apiController"></param>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns>
        /// Object recieved in response code
        /// </returns>
        public static T PutRecord(HttpClient _client, string apiController, int id, T entity)
        {
            HttpResponseMessage putRecordResponse = _client.PutAsJsonAsync($"{apiController}/{id}", entity).Result;

            //Used to ensure that response is valid - useful for debugging
            putRecordResponse.EnsureSuccessStatusCode();

            return putRecordResponse.Content.ReadAsAsync<T>().Result;
        }

        /// <summary>
        /// Sends HTTP Delete request to location specified in "_client" with directory of "apiController" and database location of "id"
        /// </summary>
        /// <param name="_client"></param>
        /// <param name="apiController"></param>
        /// <param name="id"></param>
        /// <returns>
        /// Object returned in response code
        /// </returns>
        public static T DeleteRecord(HttpClient _client, string apiController, int id)
        {
            HttpResponseMessage deleteRecordResponse = _client.DeleteAsync($"{apiController}/{id}").Result;

            //Used to ensure that response is valid - useful for debugging
            deleteRecordResponse.EnsureSuccessStatusCode();

            return deleteRecordResponse.Content.ReadAsAsync<T>().Result;
        }

    }
}
