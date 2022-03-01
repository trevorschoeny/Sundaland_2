using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sundaland.Models;
using Sundaland.Infrastructure;

namespace Sundaland.Pages
{
    public class CartModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public CartModel (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public Basket Basket { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Basket = HttpContext.Session.GetJson<Basket>("Basket") ?? new Basket();
        }

        public IActionResult OnPost(int bookID, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookID);

            // Get session data
            Basket = HttpContext.Session.GetJson<Basket>("Basket") ?? new Basket();

            // Add item to basket
            Basket.AddItem(b, 1);

            // Put back session data
            HttpContext.Session.SetJson("Basket", Basket);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
