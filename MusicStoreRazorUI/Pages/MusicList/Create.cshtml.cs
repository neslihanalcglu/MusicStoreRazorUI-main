using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicStoreRazorUI.Models;

namespace MusicStoreRazorUI.Pages.MusicList
{
    public class CreateModel : PageModel
    {
        //database le ba�lant�
        private readonly MusicStoreListContext _db;
        public CreateModel(MusicStoreListContext db)
        {
            _db = db;
        }

        [BindProperty] //backend den frontend e hemde frontend den backend e ayn� veri aktar�m�n� sa�lamak i�in
        public Music Music { get; set; }
        public void OnGet() //Get page handler
        {
          
        }
        
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)//bir de�er geldiyse
            {
                await _db.Musics.AddAsync(Music);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}

