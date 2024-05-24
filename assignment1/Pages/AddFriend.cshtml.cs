using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace assignment1.Pages
{
    public class AddFriendModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Phone { get; set; }
        [BindProperty]
        public string Address { get; set; }

        public static List<Friend> Friends = new List<Friend>();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var newFriend = new Friend
            {
                Name = Name,
                Email = Email,
                Phone = Phone,
                Address = Address
            };

            Friends.Add(newFriend);
            return RedirectToPage("Index");
        }
    }
}
