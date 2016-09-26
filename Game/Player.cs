using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// this is a PlayerCharacter with GameTime who inheritance Character
    /// </summary>
    public class Player:Character
    {
        #region Fields
        protected TimeSpan gameTime;
        #endregion


        #region Constructors
        public Player(TimeSpan gameTime, string name, byte level) : base(name, level)
        {
            GameTime = gameTime;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion


        #region Properties
        public TimeSpan GameTime
        {
            get
            {
                return gameTime;
            }

            set
            {
                gameTime = value;
            }
        } 
        #endregion
    }
}
