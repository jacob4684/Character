using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// a Character with Name and Level
    /// </summary>
    public class Character
    {

        #region Fields
        protected string name;
        protected byte level;
        #endregion


        #region Constructors
        public Character(string name, byte level)
        {
            Name = name;
            Level = level;
        } 
        #endregion


        #region Methods
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion


        #region Properties
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException();
                name = value;
            }
        }

        public byte Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }
        #endregion


    }
}
