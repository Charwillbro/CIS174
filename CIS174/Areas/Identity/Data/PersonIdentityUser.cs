using Microsoft.AspNetCore.Identity;

namespace CIS174.Areas.Identity.Data
{
    public class PersonIdentityUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }
        
    }
}
