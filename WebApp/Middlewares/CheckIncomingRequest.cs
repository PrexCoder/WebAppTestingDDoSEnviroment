using CITEO.Middlewares.IncomingRequests;

namespace CITEO.Middlewares
{
  public static class CheckIncomingRequest
  {
    public static IApplicationBuilder CheckRequest(this IApplicationBuilder builder)
    {
      return builder.UseMiddleware<RequestCheck>();
    }
  }
}
