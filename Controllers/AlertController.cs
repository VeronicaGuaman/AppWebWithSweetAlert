using System.Web.Mvc;
using static AppWebWithSweetAlert.Models.Enum;

namespace AppWebWithSweetAlert.Controllers
{
    public class AlertController : BaseController
    {
        [HttpGet]
        public ActionResult ShowAlert()
        {
            Alert("El tutorial ha finalizado con éxito", NotificationType.success);
            return View();
        }
    }
}