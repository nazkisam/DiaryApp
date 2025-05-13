
using Microsoft.AspNetCore.Mvc;
namespace DiaryApp.Controllers;
using DiaryApp.Data; 
using DiaryApp.Models; 




  public class DiaryEntriesController: Controller
  {
  private readonly ApplicationDbContext _db;

  public DiaryEntriesController(ApplicationDbContext db)
  {
_db = db;
  } 
  




public IActionResult Index()
{

List<DiaryEntry> objDiaryEntryList = _db.diaryEntries.ToList();

  return View(objDiaryEntryList);
}

public IActionResult Create(){
  return View(); 


}
[HttpPost] 
  public IActionResult Create(DiaryEntry Obj){
 _db.diaryEntries.Add(Obj);
 _db.SaveChanges();

   return RedirectToAction("Index");

  }
  
  }