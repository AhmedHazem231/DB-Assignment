using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace assignment1.Pages
{
    public class IndexModel : PageModel
    {
        public List<Friend> Friends { get; set; }

        public void OnGet()
        {
            Friends = AddFriendModel.Friends;
        }
    }

    public class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
