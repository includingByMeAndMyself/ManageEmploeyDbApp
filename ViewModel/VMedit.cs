using ManageEmploeyDbApp.Model;
using ManageEmploeyDbApp.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmploeyDbApp.ViewModel
{
    public class VMedit
    {
        public string EditDepartment(Department oldDepartment, string newName)
        {
            string result = "This department does not exist";
            using(ApplicationContext db = new ApplicationContext())
            {
                Department department = db.Departments.FirstOrDefault(d => d.Id == oldDepartment.Id);
                department.Name = newName;
                db.SaveChanges();
                result = $"Done! {department.Name} changed";
            }
            return result;
        }

        public string EditPosition(Position oldPosition, string newName, int newMaxNumber, string newSalary, Department newDepartment)
        {
            string result = "This position does not exist";
            using (ApplicationContext db = new ApplicationContext())
            {
                Position position = db.Positios.FirstOrDefault(d => d.Id == oldPosition.Id);
                position.Name = newName;
                position.MaxNumber = newMaxNumber;
                position.Salary = newSalary;
                position.DepartmetId = newDepartment.Id;
                db.SaveChanges();
                result = $"Done! {position.Name} changed";
            }
            return result;
        }

        public string EditUsers(Users oldUser, string newName, string newSurName, string newPhone, Position newPosition)
        {
            string result = "This user does not exist";
            using (ApplicationContext db = new ApplicationContext())
            {
                Users user = db.Users.FirstOrDefault(d => d.Id == oldUser.Id);
                user.Name = newName;
                user.Surname = newSurName;
                user.Phone = newPhone;
                user.PositionId = newPosition.Id;
                db.SaveChanges();
                result = $"Done! {user.Name} changed";
            }
            return result;
        }
    }
}
