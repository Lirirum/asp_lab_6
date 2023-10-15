using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Modeles
{
    public class User
    {
        
        public string Name { get; set; }

        [Range(17, 130, ErrorMessage = "Вік повинен бути в межах від 18 до 130 років")]
        public int Age { get; set; }
    }
}
