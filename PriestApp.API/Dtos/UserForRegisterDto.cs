using System.ComponentModel.DataAnnotations;

namespace PriestApp.API.Dtos
{
    public class UserForRegisterDto
    {  
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Password Length minimum 4 and Maximum 8 Chars")]
        public string Password { get; set; }

        //Dto-- means Data Transfer Object
    }
}