using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ProjectSalesWeb.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Implementando a associação de departamento com o Seller 
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }
        // Gerar constructor com todos os atributos menos as collections
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        //METODOS
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
