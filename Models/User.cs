using System.ComponentModel.DataAnnotations;

namespace MultiFormSingleView.Models
{
    public class User{

        [Required]
        public string Username {get;set;}

        [Required]
        public int Age {get;set;}

    }
}