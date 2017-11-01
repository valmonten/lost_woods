using System.ComponentModel.DataAnnotations;
namespace lost_in_the_woods.Models
{
    public class TrailViewModel : BaseEntity
    {
        public int idTrail {get;set;}
        [Required]
        public string name {get;set;}
        public string description {get;set;}
        [Required]
        public int length {get;set;}
        [Required]
        public int elevationchange {get;set;}
        [Required]
        public float longi {get;set;}
        [Required]
        public float lati {get;set;}
    }
}