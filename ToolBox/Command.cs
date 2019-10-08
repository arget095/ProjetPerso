using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    public class Command
    {
        #region Properties
        public Dictionary<string, object> Parameters { get; private set; } //Paremeters => Stocke le nom et la valeur, la valeur étant indéfinie, nous mettons le type object
        public string CommandText { get; private set; } //CommandText => String représentant notre future requête SQL
        public bool IsStoredProcedure { get; private set; } //CommandType => si true alors commandText est une procedure stockée, si false alors commandText est une requête de type texte
        #endregion

        #region Constructors
        public Command(string commandText):this(commandText,false)
        {

        }

        public Command(string commandText, bool isStoredProcedure)
        {
            if (string.IsNullOrWhiteSpace(commandText))
            {
                throw new Exception("La requête est invalide");
            }
            CommandText = commandText;
            IsStoredProcedure = isStoredProcedure;
            Parameters = new Dictionary<string, object>();
        }
        #endregion

        #region Methods
        public void AddParameter(string name, object value)
        {
            Parameters.Add(name, (value == null)?DBNull.Value:value );
        }
        #endregion
    }
}
