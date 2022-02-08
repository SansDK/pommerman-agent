using Microsoft.AspNetCore.Mvc.ModelBinding;
using PommermanAgentDotNet.Models;
using System.Text.Json;

namespace PommermanAgentDotNet.ModelBinders
{
    public class ObservationEntityBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelName = bindingContext.ModelName;

            var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

            var value = valueProviderResult.FirstValue;

            if (string.IsNullOrEmpty(value))
            {
                return Task.CompletedTask;
            }

            Observation? obs;
            try
            {
                obs = JsonSerializer.Deserialize<Observation>(
                    value,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
            catch (JsonException ex)
            {
                bindingContext.ModelState.AddModelError(modelName, ex.ToString());
                return Task.CompletedTask;
            }

            bindingContext.Result = ModelBindingResult.Success(obs);
            return Task.CompletedTask;
        }
    }
}
