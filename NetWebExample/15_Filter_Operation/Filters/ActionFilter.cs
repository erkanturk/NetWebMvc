using Microsoft.AspNetCore.Mvc.Filters;

namespace _15_Filter_Operation.Filters
{
    /* ActionFilter:Action methodunun hemen öncesi ve sonrası
     * Kullanım alanı loglama süre ölçme model durum (ModelState) kontrol ve cache işlemleri
     */
    public class ActionFilter(ILogger<ActionFilter> logger) : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            logger.LogInformation("Sonra:{Action} tamamlandı", context.ActionDescriptor.DisplayName);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
           logger.LogInformation($"Önce {context.ActionDescriptor.DisplayName} tamamlandı");
        }
    }
}
