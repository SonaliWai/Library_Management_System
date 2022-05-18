using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DataAccess.Model
{
    [Table("Publisher")]
    public class Publisher
    {
        [Key]

        [Column("Publisher_Id")]
        public int PublisherId { get; set; }

        [Column("Publisher_Name", TypeName = "varchar(100)")]
        public string PublisherName { get; set; }
    }
}
