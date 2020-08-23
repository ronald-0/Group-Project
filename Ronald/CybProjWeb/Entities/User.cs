using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CybProjWeb.Entities
{
    public class User
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public int GradeLevel { get; set; }
        public int GradeStep { get; set; }
        public string AccountId { get; set; }


        public int DepartmentId { get; set; }
        public int StateId { get; set; }
        public int LGAId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       // public string Email { get; set; }
        public string Country { get; set; }
        
        public double Housing { get; set; }
        public string HousingItemType { get; set; }

        public double Lunch { get; set; }
        public string LunchItemType { get; set; }

        public double Transport { get; set; }
        public string TransportItemType { get; set; }

        public double Medical { get; set; }
        public string MedicalItemType { get; set; }

        public double BasicSalary { get; set; }
        public double GrossSalary { get; set; }
        public double Tax { get; set; }
        public double NetSalary { get; set; }

        
        public State State { get; set; }
        public LGA LGA { get; set; } 
        public Grade Grade { get; set; }
        public Department Department { get; set; }
        public Account Account { get; set; }
        
        
        private DateTime? dateCreated = null;
        public DateTime DateCreated
        {
            get
            {
                return dateCreated.HasValue
                   ? dateCreated.Value
                   : DateTime.Now;
            }

            set { dateCreated = value; }
        }
    }
}
