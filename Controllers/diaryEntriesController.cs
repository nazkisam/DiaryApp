using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
  public class diaryEntriesController: Controller
  {

public IActionResult Index()
{
  return View();
}

  }
}