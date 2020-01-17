
using System;
using System.Collections.Generic;

namespace E_05_Military
{
    public class Commando : Soldier, IPrivate, ISpecializedSoldier, ICommando
    {
        private decimal salary;
        private string corps;
        private Dictionary<string, string> missions;

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }


        public string Corps
        {
            get
            {
                return this.corps;
            }
            set
            {
                this.corps = value;
            }
        }
        public Dictionary<string, string> Missions
        {
            get
            {
                return this.missions;
            }
            set
            {
                this.missions = value;
            }
        }

        public void CompleteMission()
        {
            throw new System.NotImplementedException();
        }

        public Commando(string id, string firstNamd,string lastName, decimal salary, string corps)
            :base(id,firstNamd,lastName)
        {
            this.Corps = corps;
            this.Salary = salary;
            this.Missions = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            var outPut = base.ToString() + $" Salary: {this.Salary} " + Environment.NewLine +
                 $"Corps: {this.Corps} " + Environment.NewLine +
             "Missions:"; 

            foreach(var mission in this.Missions)
            {
                outPut += Environment.NewLine+"Name: " + mission.Key + Environment.NewLine + "Status: "+ mission.Value ;
            }

            return outPut;
        }

    }
}
