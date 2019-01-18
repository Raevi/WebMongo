using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebMongo.Model;
using WebMongo.Service;

namespace WebMongo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MongoService _service;

        public List<Formation> Formations { get; private set; }



        public IndexModel(MongoService service)
        {
            _service = service;
        }



        public void OnGet()
        {
            Formations = _service.Get();
        }
    }
}
