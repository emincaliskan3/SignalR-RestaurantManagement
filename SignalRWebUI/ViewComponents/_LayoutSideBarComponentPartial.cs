using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents
{
	public class _LayoutSideBarComponentPartial:ViewComponent
	{ public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
