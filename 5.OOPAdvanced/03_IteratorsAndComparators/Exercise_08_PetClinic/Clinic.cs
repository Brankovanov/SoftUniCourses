using System;
using System.Linq;

namespace Exercise_08_PetClinic
{
    //Clinic class that holds the logic for the clinic functionality.
    public class Clinic
    {
        private Pet[] pets;
        private int rooms;
        private string name;
        private int counter = 0;
        private int direction = 0;
        private int startingIndex;

        public int StartingIndex
        {
            get
            {
                return this.startingIndex;
            }
            set
            {
                this.startingIndex = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }
                else
                {
                    this.rooms = value;
                }
            }
        }

        public Pet[] Pets
        {
            get
            {
                return this.pets;
            }
            set
            {
                this.pets = value;
            }
        }

        public Clinic(int rooms, string name)
        {
            this.Name = name;
            this.Rooms = rooms;
            this.Pets = new Pet[rooms];
            this.StartingIndex = (int)(Math.Ceiling((double)(this.Rooms / 2)));
        }

        public bool Admiting(Pet pet)
        {
            if (this.direction == 0)
            {
                this.Pets[startingIndex] = pet;
                this.direction++;
                return true;
            }
            else if (this.startingIndex + this.direction - 1 <= this.rooms && this.direction % 2 == 0)
            {
                this.Pets[this.startingIndex + this.direction - 1] = pet;
                this.direction++;
                return true;
            }
            else if (this.startingIndex - this.direction >= 0 && this.direction % 2 != 0)
            {
                this.Pets[this.startingIndex - this.direction] = pet;
                this.direction++;
                return true;
            }
            else if (this.Pets[0] == null)
            {
                this.Pets[0] = pet;
                return true;
            }
            else if (this.Pets[this.Pets.Length - 1] == null)
            {
                this.Pets[this.Pets.Length - 1] = pet;
                return true;
            }

            return false;
        }

        public bool Releasing()
        {
            if (this.counter == 0 && this.Pets[this.StartingIndex] != null)
            {
                this.Pets[this.StartingIndex] = null;
                this.counter++;
                return true;
            }
            else if (this.counter + this.StartingIndex < this.rooms && this.Pets[this.startingIndex + this.counter] != null)
            {
                this.Pets[this.startingIndex + this.counter] = null;
                this.counter++;
                return true;
            }
            else if (this.StartingIndex - this.counter < this.startingIndex && this.Pets[this.startingIndex - this.counter] != null)
            {
                this.Pets[this.startingIndex - this.counter] = null;
                this.counter--;
                return true;
            }

            return false;
        }

        public bool HasEmpty()
        {
            if (this.Pets.Contains(null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Print()
        {
            var output = string.Empty;

            foreach (var room in this.Pets)
            {
                if (room == null)
                {
                    output += "Room empty" + Environment.NewLine;
                }
                else
                {
                    output += room.Name + " " + room.Age + " " + room.Kind + Environment.NewLine;
                }
            }

            return output;
        }

        public string PrintRoom(int room)
        {
            if (this.Pets[room - 1] == null)
            {
                return "Room empty";
            }
            else
            {
                return this.Pets[room - 1].Name + " " + this.Pets[room - 1].Age + " " + this.Pets[room - 1].Kind;
            }
        }
    }
}