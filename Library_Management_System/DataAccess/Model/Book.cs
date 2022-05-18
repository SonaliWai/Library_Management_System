using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataAccess.Model
{
    [Table("BookTable")]
    [Index("BookCode", IsUnique = true)]
    public class Book
    {

        [Key]
        [Column("Book_Id")]
        public int BookId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string BookCode { get; set; }

        [Column("Book_Title", TypeName = "varchar(100)")]
        public string BookTitle { get; set; }

        [Column("Book_Price")]
        public int BookPrice { get; set; }

        [Column("Author_Id")]
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author author { get; set; }

        [Column("Publisher_Id")]
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher publisher { get; set; }


        public static string Header => "|BookId | BookCode | BookTitle | BookPrice | AuthorId | PublisherId |";
    }
}
