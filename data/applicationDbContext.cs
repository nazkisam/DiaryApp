using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data

{
    public class applicationDbContext: DbContext
    {
        public applicationDbContext(DbContextOptions<applicationDbContext>options): base(options) {

            
        }


        public DbSet<DiaryEntry> diaryEntries{get;set;}

     }
}