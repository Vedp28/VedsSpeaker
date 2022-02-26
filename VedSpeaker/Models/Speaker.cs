using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VedSpeaker.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(20)]
        public string Features{ get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(20)]
        public string Types { get; set; }
        [Display(Name = "Battery Life")]
        [Range(1,40)]
        public int BatteryLife { get; set; }
        [Range(1,30)]
        public int Size { get; set; }
        [Range(1,5)]
        public int Rating { get; set; }
        [Range(1, 400), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
