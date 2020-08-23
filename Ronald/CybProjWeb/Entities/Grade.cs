using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CybProjWeb.Entities
{
    public class Grade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string GradeName { get; set; }
        public int GradeLevel { get; set; }
        public int GradeStep { get; set; }
        public string GradeLevels { get; set; }
        public string GradeSteps { get; set; }
        public double BasicSalary { get; set; }
        public double Housing { get; set; }
        public double HousingPercent { get; set; }
        public string HousingItemType { get; set; }

        public double Tax { get; set; }
        public double TaxPercent { get; set; }
        // public string TaxItemType { get; set; }

        public double Lunch { get; set; }
        public string LunchItemType { get; set; }
        public double LunchPercent { get; set; }

        public double Transport { get; set; }
        public double TransportPercent { get; set; }
        public string TransportItemType { get; set; }

        public double Medical { get; set; }
        public double MedicalPercent { get; set; }
        public string MedicalItemType { get; set; }

        public double NetSalary { get; set; }
        public double GrossSalary { get; set; }

        public string CreatedBy { get; set; }
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
