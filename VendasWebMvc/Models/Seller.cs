using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O {0} é Obrigatório!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do {0} deve ser entre {2} e {1} caracteres")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]

        [Required(ErrorMessage = "O {0} é Obrigatório!")]
        [EmailAddress(ErrorMessage = "Insira um email em formato válido!")]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "O {0} é Obrigatório!")]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required]
        [Range(100.0, 10000.0, ErrorMessage = "{0} Deve ser entre {1} e {2}")]
        public double BaseSalary { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "O {0} é Obrigatório!")]
        public Department department { get; set; }

        [Display(Name = "ID do Departamento")]
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDay, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDay = birthDay;
            BaseSalary = baseSalary;
            this.department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }

    }
}
