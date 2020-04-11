using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class UserProcessor
    {
        public static int SaveUser(Guid userId, string firstName, string lastName, string phoneNumber, string address, string city, string state, int zip, string email, string password, DateTime dOB, bool isEmployee, bool isManager, bool isMember)
        {
            UserModel data = new UserModel
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Address = address,
                City = city,
                State = state,
                Zip = zip,
                Email = email,
                Password = password,
                DOB = dOB,
                IsEmployee = isEmployee,
                IsManager = isManager,
                IsMember = isMember
            };
            string sql = @"insert into dbo.Users (UserId, FirstName, LastName, PhoneNumber, Address, City, State, Zip, Email, Password, DOB, IsEmployee, IsManager, IsMember)
                            values (@UserId, @FirstName, @LastName, @PhoneNumber, @Address, @City, @State, @Zip, @Email, @Password, @DOB, @IsEmployee, @IsManager, @IsMember);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static int DeleteUser(Guid userId)
        {
            string sql = "delete from dbo.Users where UserId = @UserId";

            return SqlDataAccess.DeleteData(sql, userId);
        }

        public static List<UserModel> LoadUsers()
        {
            string sql = @"select UserId, FirstName, LastName, PhoneNumber, Address, City, State, Zip, Email, Password, DOB, IsEmployee, IsManager, IsMember
                            from dbo.Users;";

            return SqlDataAccess.LoadData<UserModel>(sql);
        }
    }
}
