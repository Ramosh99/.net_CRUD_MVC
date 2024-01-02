using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Project01.Models
{
    public class Category
    {
        //[Required]
        [Key]//below one will primary key
        public int Id { get; set; }//or we can use {public int CategoryId then also will make primary key auto}
        
        public string Name { get; set; }
        
        public string DisplayOrder { get; set; }
    }
}
