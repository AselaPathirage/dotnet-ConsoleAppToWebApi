using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ConsoleApptoAPI
{
	public class CustomBinder : IModelBinder
	{
		public Task BindModelAsync(ModelBindingContext bindingContext)
		{
			var data = bindingContext.HttpContext.Request.Query;
			var result = data.TryGetValue("countries", out var countries);
			if (result)
			{
				var array = countries.ToString().Split('|');
				bindingContext.Result = ModelBindingResult.Success(array);
			}
			return Task.CompletedTask;
		}
	}
}