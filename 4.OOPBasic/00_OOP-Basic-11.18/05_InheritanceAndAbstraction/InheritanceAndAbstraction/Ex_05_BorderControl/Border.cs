
using System.Collections.Generic;

namespace Ex_05_BorderControl
{
    public class Border
    {
        private List<Entity> rebels;

        public List<Entity> Rebels
        {
            get
            {
                return this.rebels;
            }
            set
            {
                this.rebels = value;
            }
        }

        public Border()
        {
            this.Rebels = new List<Entity>();
        }

        public  void Detain(string filter, Entity entity)
        {
            if(entity.Id.EndsWith(filter))
            {
                this.Rebels.Add(entity);
            }
        }

    }
}
