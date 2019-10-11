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
    public class CategoryRepository
    {
        private Connection _Connection { get; set; }

        public CategoryRepository()
        {
            _Connection = new Connection(@"Data Source=TECHNOBEL\;Initial Catalog=ProjetPerso;User ID=sa;Password=test1234=",
                "System.Data.SqlClient");
        }

        public Category Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Category WHERE IdCategory = @Id");
            cmd.AddParameter("@Id", id);

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.CategoryMapper).SingleOrDefault();
        }

        public IEnumerable<Category> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Category");

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.CategoryMapper);
        }
    }
}
