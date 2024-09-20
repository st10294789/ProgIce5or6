using System.ComponentModel.DataAnnotations;

namespace ProgIce5or6
{

    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Birth Year is required")]
        public int YearOfBirth { get; set; }
    }
}