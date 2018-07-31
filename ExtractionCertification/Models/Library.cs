using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtractionCertification.Models
{
    [Table("Library")]
    public class Library
    {
        [Key]
        public int id { get; set; }
        [StringLength(100)]
        public string projname_ar { get; set; }
        [StringLength(100)]
        public string projname_en { get; set; }
        [MaxLength]
        public byte[] pdffile { get; set; }
        [MaxLength]
        public byte[] docfile { get; set; }
        [StringLength(10)]
        public int studentphone { get; set; }
    }
}