using ProjetPerso.DAL.Entities;
using ProjetPerso.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox;

namespace ProjetPerso.DAL.Services
{
    public class UserRepository
    {
        private Connection _Connection { get; set; }

        public UserRepository()
        {
            #region sql formation
            _Connection = new Connection(@"Data Source=TECHNOBEL\;Initial Catalog=ProjetPerso;User ID=sa;Password=test1234=", "System.Data.SqlClient");
            #endregion
            #region sql maison
            //_Connection = new Connection(@"Data Source = DESKTOP-8OP2MN3; Initial Catalog = ProjetPerso; Integrated Security = True", "System.Data.SqlClient");
            #endregion
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
            Command cmd = new Command("SELECT * FROM [User] WHERE IdUser = @Id");
            cmd.AddParameter("@Id", id);

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.UserMapper).SingleOrDefault();
        }

        public IEnumerable<User> GetAll()
        {
            Command cmd = new Command("SELECT * FROM [User]");

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.UserMapper);
        }

        public void UpdateMail(string pseudo,string newmail)
        {
            Command cmd = new Command("Update User Set Mail = @Newmail where Pseudo = @pseudo");
            cmd.AddParameter("@Newmail", newmail);
            cmd.AddParameter("@pseudo", pseudo);

            _Connection.ExecuteNonQuery(cmd);
        }

        public void UpdatePassword(string pseudo, string newpassword)
        {
            Command cmd = new Command("Update User Set Password = @Newpassword where Pseudo = @pseudo");
            cmd.AddParameter("@Newpassword", newpassword);
            cmd.AddParameter("@pseudo", pseudo);

            _Connection.ExecuteNonQuery(cmd);
        }

        public void Delete(int id)
        {
            Command cmd = new Command("DELETE FROM [User] WHERE IdUser = @Id");
            cmd.AddParameter("@Id", id);

            _Connection.ExecuteNonQuery(cmd);
        }
        public bool CheckUserByPseudoAndPassword(string pseudo,string password)
        {
            Command cmd = new Command("SELECT * FROM [User] where Pseudo = @pseudo and Password = @password");
            cmd.AddParameter("@pseudo", pseudo);
            cmd.AddParameter("@password", password);

            IEnumerable<User> list = _Connection.ExecuteReader(cmd, DbToEntityMapper.UserMapper);

            if (list.Count() > 0)return true;

            return false;
        }

    }
}
