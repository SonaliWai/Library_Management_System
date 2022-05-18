using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataAccess.Model
{
    [Table("Author_table")]
    public class Author
    {
        [Key]
        [Column("Author_Id")]
        public int AuthorId { get; set; }

        [Column("Author_Name", TypeName = "varchar(100)")]
        public string AuthorName { get; set; }
    }
}
