using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Engines
    {
        private int engineSpeed;
        private int enginePower;

        public int EnginePower
        {
            get
            {
                return this.enginePower;
            }
            set
            {
                this.enginePower = value;
            }
        }

        public int EngineSpeed
        {
            get
            {
                return this.engineSpeed;
            }
            set
            {
                this.engineSpeed = value;
            }
        }

        public Engines(int power, int speed)
        {
            this.EnginePower = power;
            this.EngineSpeed = speed;
        }
    }
}
