
namespace Ex_05_BorderControl
{
    public class Robot :Entity
    {
        private string model;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public Robot(string id, string model)
            : base()
          
        {
            this.Id = id;
            this.Model = model;
        }
    }
}
