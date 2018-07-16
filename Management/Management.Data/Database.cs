using System;
using System.Collections.Generic;
using System.Text;
using Management.Domain.Models;
using System.IO;

namespace Management.Data
{
    public class Database
    {
        public Database()
        {
            _connectionString = File.ReadAllText("C:\\Users\\chees\\Desktop\\Art\\settings.txt");
        }

        private string _connectionString;

        public void AddUser(User user)
        {
            using (DatabaseContext context = new DatabaseContext(_connectionString))
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
