using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmploeyDbApp.Model
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public int MaxNumber { get; set; }
        public List<Users> Users {get; set;}
        public int DepartmetId { get; set; }
        public virtual Department Department { get; set; }
    }
}
