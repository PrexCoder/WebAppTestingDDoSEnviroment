namespace CITEO.Middlewares.IncomingRequests
{
  public class RequestCheck
  {
    private readonly RequestDelegate _next;

    public RequestCheck(RequestDelegate next)
    {
      _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
      
      Console.WriteLine($"Request incoming: {context.Request.ContentLength} | {DateTime.Now.ToString("hh:mm:ss")}");

      await _next(context);
    }
  }
}
