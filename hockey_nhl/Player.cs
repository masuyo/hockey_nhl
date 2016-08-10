using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hockey_nhl
{
    class Player
    {
        private string name;
        private string height;
        private StatusOptions status;
        private PositionOptions position;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public StatusOptions Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public PositionOptions Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public Player(string name, string height, StatusOptions status, PositionOptions position)
        {
            this.Name = name;
            this.Height = height;
            this.Status = status;
            this.Position = position;
        }
    }

    public enum StatusOptions
    {
        Active, Injured, Minors
    }

    public enum PositionOptions
    {
        Center, Back, LeftWing, RightWing, Goalie
    }
}
