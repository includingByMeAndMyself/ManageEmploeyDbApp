using ManageEmploeyDbApp.Model;
using ManageEmploeyDbApp.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmploeyDbApp.ViewModel
{
    public class VMCreate
    {
        public string CreateDepartment(string name)
        {
            string result = "Already exists";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли отдел
                bool chekIsExist = db.Departments.Any(el => el.Name == name);
                if (!chekIsExist)
                {
                    Department newDepartment = new Department { Name = name };
                    db.Departments.Add(newDepartment);
                    db.SaveChanges();
                    result = "Done!";
                }
                return result;
            }
        }

        public string CreatePosition(string name, string salary, int maxNumber, Department department)
        {
            string result = "Already exists";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли позиция
                bool chekIsExist = db.Positios.Any(el => el.Name == name && el.Salary == salary);
                if (!chekIsExist)
                {
                    Position newPosition = new Position
                    {
                        Name = name,
                        Salary = salary,
                        MaxNumber = maxNumber,
                        DepartmetId = department.Id

                    };
                    db.Positios.Add(newPosition);
                    db.SaveChanges();
                    result = "Done!";
                }
                return result;
            }
        }

        public string CreateUser(string name, string surName, string phone, Position position)
        {
            string result = "alredy exists";
            using (ApplicationContext db = new ApplicationContext())
            {
                bool checkIsExist = db.Users.Any(el =>
                el.Name == name &&
                el.Surname == surName &&
                el.Position == position);
                if (!checkIsExist)
                {
                    Users newUser = new Users
                    {
                        Name = name,
                        Surname = surName,
                        Phone = phone,
                        PositionId = position.Id
                    };
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    result = "Done!";
                }
                return result;
            }
        }
    }
}
