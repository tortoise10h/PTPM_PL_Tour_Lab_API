using Microsoft.AspNetCore.Http;

namespace src.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GenerateResouceOfCreatedObject(this HttpContext httpContext, string getItemUri)
        {
            var baseUrl = $"{httpContext.Request.Scheme}://{httpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + getItemUri;

            return locationUri;
        }
    }
}