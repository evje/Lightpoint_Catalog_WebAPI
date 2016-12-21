using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Entities
{
    public class Good
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        //public Int32 StoreId { get; set; }

        [Required]
        [MaxLength(100)]
        public String Name { get; set; }

        [Required]
        [MaxLength(100)]
        public String Description { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
