using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Dairy : IEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public DateTime DateTime { get; set; }
        public string TopicToStudy { get; set; }
        public string Sources { get; set; }
        public string Notes { get; set; }
        



    }
}
