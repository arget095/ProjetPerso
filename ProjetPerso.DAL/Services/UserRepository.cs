using ProjetPerso.DAL.Entities;
using ProjetPerso.DAL.Interfaces;
using ProjetPerso.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox;

namespace ProjetPerso.DAL.Services
{
    public class UserRepository : IRepository<int,User>
    {
        private Connection _Connection { get; set; }

        public UserRepository()
        {
            _Connection = new Connection(@"Data Source=TECHNOBEL\;Initial Catalog=ProjetPerso;User ID=sa;Password=test1234=",
                "System.Data.SqlClient");
        }

        public int Create(User entity)
        {
            Command cmd = new Command("AddUser", true);

            cmd.AddParameter("@FirstName", entity.FirstName);
            cmd.AddParameter("@LastName", entity.LastName);
            cmd.AddParameter("@Pseudo", entity.Pseudo);
            cmd.AddParameter("@Mail", entity.Mail);
            cmd.AddParameter("@Password", entity.Password);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public User Get(int id)
        {
            Command cmd = new Command("SELECT * FROM User WHERE Id = @Id");
            cmd.AddParameter("@Id", id);

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.UserMapper).SingleOrDefault();
        }

        public IEnumerable<User> GetAll()
        {
            Command cmd = new Command("SELECT * FROM User");

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.UserMapper);
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Command cmd = new Command("DELETE FROM User WHERE Id = @Id");
            cmd.AddParameter("@Id", id);

            _Connection.ExecuteNonQuery(cmd);
        }

    }
}
