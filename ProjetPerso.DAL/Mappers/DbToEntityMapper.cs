using ProjetPerso.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso.DAL.Mappers
{
    public class DbToEntityMapper
    {
        public static User UserMapper(IDataReader reader) /*permet de retrouver les données dans la DB*/
        {
            return new User()
            {
                Id = (int)reader["IdUser"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Pseudo = reader["Pseudo"].ToString(),
                Mail = reader["Mail"].ToString()
                
            };
        }

        public static Event EventMapper(IDataReader reader)
        {
            return new Event()
            {
                Id = (int)reader["IdEvent"],
                Name = reader["Name"].ToString(),
                Participant = (int)reader["Participant"],
                IdCountry = reader["IdCountry"].ToString(),
                IdCityPostalCode = reader["IdCityPostalCode"].ToString(),
                Admin = (int)reader["Admin"],
                IdLoisir = (int)reader["IdLoisir"],
                Time = (DateTime)reader["Time"]
            };
        }

        public static Participant ParticipantMapper(IDataReader reader)
        {
            return new Participant()
            {
                IdEvent = (int)reader["IdEvent"],
                IdUser = (int)reader["IdUser"]
            };
        }

        public static Country CountryMapper(IDataReader reader)
        {
            return new Country()
            {
                Id = reader["IdCountry"].ToString(),
                Name = reader["Name"].ToString()
            };
        }

        public static City CityMapper(IDataReader reader)
        {
            return new City()
            {
                Id = (int)reader["IdCity"],
                PostalCode = reader["PostalCode"].ToString(),
                Name = reader["Name"].ToString(),
                IdCountry = reader["IdCountry"].ToString()
            };
        }

        public static Loisir LoisirMapper(IDataReader reader)
        {
            return new Loisir()
            {
                IdLoisir = (int)reader["IdLoisir"],
                Name = reader["Name"].ToString(),
                NameCategory = reader["NameCategory"].ToString()
            };
        }

        public static Category CategoryMapper(IDataReader reader)
        {
            return new Category()
            {
                IdCategory = (int)reader["IdCategory"],
                Name = reader["Name"].ToString()
            };
        }
    }
}
