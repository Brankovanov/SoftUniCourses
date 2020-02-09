using System;
using System.Text;

namespace LogoBuilder
{
    class Builder
    {
        private int logoSize;

        public int LogoSize { get => logoSize; set => logoSize = value; }

        //Merges the upper and the lower parts of the logo together and returns the final finished version of the logo.
        public string Build()
        {
            var logo = string.Empty;
            logo += BuilldUpper();
            logo += BuildLower();

            return (logo);
        }

        //Builds the lower half of the logo using StringBuilder and returns it to LBuilder method.
        private string BuildLower()
        {
            var demo = string.Empty;
            var sb = new StringBuilder();

            sb.Append('-', (int)Math.Floor((double)this.LogoSize / 2))
              .Append('*', this.LogoSize)
              .Append('-', 1)
              .Append('*', this.LogoSize * 2 - 1)
              .Append('-', 1)
              .Append('*', this.LogoSize)
              .Append('-', (int)Math.Floor((double)this.LogoSize / 2))
              .Append('-', (int)Math.Floor((double)this.LogoSize / 2))
              .Append('*', this.LogoSize)
              .Append('-', 1)
              .Append('*', this.LogoSize * 2 - 1)
              .Append('-', 1)
              .Append('*', this.LogoSize)
              .Append('-', (int)Math.Floor((double)this.LogoSize / 2))
              .Append(Environment.NewLine);

            for (var row = 1; row < Math.Ceiling((double)this.LogoSize / 2); row++)
            {
                sb.Append('-', (int)Math.Floor((double)this.LogoSize / 2) - row)
                  .Append('*', this.LogoSize)
                  .Append('-', 2 * row + 1)
                  .Append('*', (this.LogoSize * 2 - 1) - row * 2)
                  .Append('-', 2 * row + 1)
                  .Append('*', this.LogoSize)
                  .Append('-', (int)Math.Floor((double)this.LogoSize / 2) - row)
                  .Append('-', (int)Math.Floor((double)this.LogoSize / 2) - row)
                  .Append('*', this.LogoSize)
                  .Append('-', 2 * row + 1)
                  .Append('*', (this.LogoSize * 2 - 1) - row * 2)
                  .Append('-', 2 * row + 1)
                  .Append('*', this.LogoSize)
                  .Append('-', (int)Math.Floor((double)this.LogoSize / 2) - row)
                  .Append(Environment.NewLine);
            }

            demo += sb.ToString();

            return demo;
        }

        //Builds the upper half of the logo using StringBuilder and returns it to the Build method.
        private string BuilldUpper()
        {
            var demo = string.Empty;
            var sb = new StringBuilder();

            sb.Append('-', this.LogoSize)
              .Append('*', this.LogoSize)
              .Append('-', this.LogoSize)
              .Append('*', this.LogoSize)
              .Append('-', this.LogoSize)
              .Append('-', this.LogoSize)
              .Append('*', this.LogoSize)
              .Append('-', this.LogoSize)
              .Append('*', this.LogoSize)
              .Append('-', this.LogoSize)
              .Append(Environment.NewLine);

            for (var row = 1; row < Math.Ceiling((double)this.LogoSize / 2); row++)
            {
                sb.Append('-', this.LogoSize - row)
                  .Append('*', this.LogoSize + 2 * row)
                  .Append('-', this.LogoSize - 2 * row)
                  .Append('*', this.LogoSize + 2 * row)
                  .Append('-', this.LogoSize - row)
                  .Append('-', this.LogoSize - row)
                  .Append('*', this.LogoSize + 2 * row)
                  .Append('-', this.LogoSize - 2 * row)
                  .Append('*', this.LogoSize + 2 * row)
                  .Append('-', this.LogoSize - row)
                  .Append(Environment.NewLine);
            }

            demo += sb.ToString();

            return demo;
        }

        public Builder(int size)
        {
            this.LogoSize = size;
        }
    }
}