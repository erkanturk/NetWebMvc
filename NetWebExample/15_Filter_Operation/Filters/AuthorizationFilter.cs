using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _15_Filter_Operation.Filters
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        //Request istemcinin sunucuya gönderdiği istek
        //Response Sunucunun bu isteğe karşılık döndürdüğü yanıt
        //Result işlem sonucunu ifade eder kullanıldığı yere göre response içindeki veriyi veya işlemin çıktısını temsil eder.
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;//isteği yapan kullanıcı kimliği browserda siteyi açan kullanıcı
            //?. ve ??: Identity null olabilir (?) ?? null ise giriş yapmamış durumu false dönsün.
            var girisYapilmis = user.Identity?.IsAuthenticated ?? false;
            if (!girisYapilmis)
            {
                context.Result = new RedirectToActionResult("Login", "Account", null);
            }
        }
    }
}
