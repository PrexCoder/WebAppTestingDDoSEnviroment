using T01_WebApp.Middlewares.IncomingRequests;

namespace T01_WebApp.Middlewares
{
  public static class CheckIncomingRequest
  {
    public static IApplicationBuilder CheckRequest(this IApplicationBuilder builder)
    {
      return builder.UseMiddleware<RequestCheck>();
    }
  }
}
