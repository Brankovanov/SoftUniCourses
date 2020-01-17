using System;

namespace Lab_02_Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double widht;

    

        public Rectangle(double height,double widht)
        {
            this.Height = height;
            this.Widht = widht;
        }

        public double Height { get => height; set => height = value; }
        public double Widht { get => widht; set => widht = value; }

        public override double CalculateArea()
        {
            return this.Height* this.Widht;
        }

        public override double CalculatePerimeter()
        {
            return (2*this.Height) + (2*this.Widht);
        }

        public override string Draw()
        {
            var drawing = string.Empty;

            drawing += new string('*', (int)this.Widht)+ Environment.NewLine;

            for(var rows =0; rows<this.Height-2;rows++)
            {
                drawing+='*'+ new string(' ', (int)this.Widht-2)+'*' + Environment.NewLine;
            }

            drawing += new string('*', (int)this.Widht) + Environment.NewLine;

            return drawing;
        }
    }
}
