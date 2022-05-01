namespace ConsoleApptoAPI
{
	public class CustomMiddleware : IMiddleware
	{
		public async Task InvokeAsync(HttpContext context, RequestDelegate next)
		{
			await context.Response.WriteAsync("Hello from custom Use2 1 \n");
			await next(context);
			await context.Response.WriteAsync("Hello from custom Use2 2 \n");
		}
	}
}