using System.ComponentModel.DataAnnotations;
namespace lost_in_the_woods.Models
{
    public class Place : BaseEntity
    {
        [Key]
        public int idTrail {get;set;}
        public string name {get;set;}
        public string description {get;set;}
        public int length {get;set;}
        public int elevationchange {get;set;}
        public float longi {get;set;}
        public float lati {get;set;}
    }
}