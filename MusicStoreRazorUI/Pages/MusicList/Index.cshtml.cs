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
    public class IndexModel : PageModel
    {
        //database le ba�lant�
        private readonly MusicStoreListContext _db;
        public IndexModel(MusicStoreListContext db)
        {
            _db = db;
        }

        //Birden fazla s�n�ftan listeleyebiliriz o y�zden IEnumerable ile belirtiyoruz nerden alaca��n�
        public IEnumerable<Music> Musics { get; set; }
        public async Task OnGet() //Get page handler
        {
            //asenkron olarak datalar� �ekiyoruz
            Musics = await _db.Musics.ToListAsync();
        }
    }
}
