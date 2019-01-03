using Microsoft.AspNetCore.Http;

namespace PriestApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Appication-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Appication-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}