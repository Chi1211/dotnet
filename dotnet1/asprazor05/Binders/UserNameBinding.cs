using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class UserNameBinding : IModelBinder{

    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        if(bindingContext==null)
        {
            throw new ArgumentNullException("bindingContext");
        }
        string modelName=bindingContext.ModelName;
        var valueProviderResult=bindingContext.ValueProvider.GetValue(modelName);
        if(valueProviderResult==ValueProviderResult.None)
        {
            return Task.CompletedTask;
        }
        string value=valueProviderResult.FirstValue;
        if(string.IsNullOrEmpty(value))
        {
            return Task.CompletedTask;
        }

        value=value.ToUpper();
        if(value.Contains("XXX"))
        {
            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);
            bindingContext.ModelState.TryAddModelError(modelName, "Không được chứa XXX");
            return Task.CompletedTask;
        }

        value=value.Trim();
        bindingContext.ModelState.SetModelValue(modelName, value, value);
        bindingContext.Result=ModelBindingResult.Success(value);
        return Task.CompletedTask;
    }
   
}