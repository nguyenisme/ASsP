﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Database.Models
{
    [Table("Group")]
    public class Group
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(150)]
        public string? Name { get; set; }
        public ICollection<Member> Memmber { get; set; } = new HashSet<Member>();
        public ICollection<Authorized> Authorizeds { get; set; } = new HashSet<Authorized>();
    }
}
