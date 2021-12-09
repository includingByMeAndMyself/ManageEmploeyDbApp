using ManageEmploeyDbApp.Model;
using ManageEmploeyDbApp.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmploeyDbApp.ViewModel
{
    public class VMRemove
    {
        public string DeleteDepartment(Department department)
        {
            string result = "department does not exist";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Departments.Remove(department);
                db.SaveChanges();
                result = $"{department.Name} has been dlete!";
            }
            return result;
        }

        public  string DeletePosition(Position position)
        {
            string result = "position does not exist";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Positios.Remove(position);
                db.SaveChanges();
                result = $"{position.Name} has been dlete!";
            }
            return result;
        }

        public  string DeleteUser(Users user)
        {
            string result = "User does not exist";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Remove(user);
                db.SaveChanges();
                result = $"{user.Name} has been dlete!";
            }
            return result;
        }
    }
}
