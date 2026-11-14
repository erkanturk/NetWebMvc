using _15_Filter_Operation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace _15_Filter_Operation.Filters
{
    public class ExceptionFilter(ILogger<ExceptionFilter> logger) : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            logger.LogError(context.Exception, "Action hata fırlattı:{Action}", context.ActionDescriptor.DisplayName);

            context.Result = new ViewResult()
            {
                ViewName="Error",
                ViewData=new ViewDataDictionary(new EmptyModelMetadataProvider(),context.ModelState)
                {
                    Model=new ErrorViewModel
                    {
                        RequestId=context.HttpContext.TraceIdentifier,
                        ErrorMessage=context.Exception.Message
                    }
                }
            };
            context.ExceptionHandled= true;
        }
    }
}
