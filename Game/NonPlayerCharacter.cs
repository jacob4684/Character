using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// this is a NonPlayerCharacter with IsActive who inheritance Character
    /// </summary>
    public class NonPlayerCharacter :Character
    {

        #region Fields
        protected bool isActive;
        #endregion


        #region Constructors
        public NonPlayerCharacter(string name, byte level, bool isActive) : base(name, level)
        {
            IsActive = isActive;
        }
        #endregion


        #region Methods
        public override string ToString()
        {
            return base.ToString();
        } 
        #endregion


        #region Properties
        public bool IsActive
        {
            get
            {
                return isActive;
            }

            set
            {
                
                isActive = value;
            }
        } 
        #endregion
    }
}
