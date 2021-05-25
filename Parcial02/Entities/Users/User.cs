using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Parcial02.Entities.Questions;
namespace Parcial02.Entities.Users

{
    public class User
    {
        // Columnas de la tabla User
        
        [Key]
        public string CardId { get; set; }
        
        public string FullName { get; set; }
        
        public string Password { get; set; }
        
        public virtual Question SecurityQuestion { get; set; }
        
        public string SecurityAnswer { get; set; }

    }
}