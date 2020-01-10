using System;

namespace Hangman
{
    public class Drawer
    {
        private string head;
        private string neck;
        private string body;
        private string legs;

        public string Head { get => head; set => head = value; }
        public string Body { get => body; set => body = value; }
        public string Neck { get => neck; set => neck = value; }
        public string Legs { get => legs; set => legs = value; }

        public void DrawGallow()
        {
            Console.WriteLine(" " + new string('_', 25));
            Console.WriteLine("|" + new string('_', 25) + "|");

            for (var ropeRow = 0; ropeRow <= 2; ropeRow++)
            {
                Console.WriteLine("| |" + new string(' ', 21) + "|");
            }

            Console.WriteLine(this.Head);
            Console.WriteLine(this.Neck);
            Console.WriteLine(this.Body);
            Console.WriteLine(this.Legs);

            for (var row = 0; row <= 2; row++)
            {
                Console.WriteLine("| |");
            }

            Console.WriteLine("|_|");
        }

        public void DrawHead()
        {
            this.Head = "| |" + new string(' ', 18) + new string('_', 3) + "|" + new string('_', 3) + Environment.NewLine +
                        "| |" + new string(' ', 17) + "| o   o |" + Environment.NewLine +
                        "| |" + new string(' ', 17) + "| \\___/ |" + Environment.NewLine +
                        "| |" + new string(' ', 17) + "\\_______/";
        }

        public void DrawNeck()
        {
            this.Neck = "| |" + new string(' ', 18) + " |  |  ";
        }

        public void DrawBody()
        {
            this.Neck = "| |" + new string(' ', 17) + "__|  |__";

            this.Body = "| |" + new string(' ', 16) + "/" + new string(' ', 8) + "\\" + Environment.NewLine
                      + "| |" + new string(' ', 16) + "|" + new string(' ', 8) + "|" + Environment.NewLine
                      + "| |" + new string(' ', 16) + "|" + new string(' ', 8) + "|" + Environment.NewLine
                      + "| |" + new string(' ', 16) + "|" + new string(' ', 8) + "|" + Environment.NewLine
                      + "| |" + new string(' ', 16) + "|" + new string(' ', 8) + "|" + Environment.NewLine
                      + "| |" + new string(' ', 16) + "\\" + new string('_', 8) + "/";
        }

        public void DrawRightLeg()
        {
            this.Legs = this.Legs = "| |" + new string(' ', 15) + "/ /" + new string(' ', 6) + "\\ \\" + Environment.NewLine
                     + "| |" + new string(' ', 14) + "/ /" + new string(' ', 8) + "\\ \\" + Environment.NewLine
                     + "| |" + new string(' ', 11) + "__/ /" + new string(' ', 10) + "\\ \\__" + Environment.NewLine
                     + "| |" + new string(' ', 10) + "|____|" + new string(' ', 10) + "|____|";
        }

        public void DrawLeftLeg()
        {
            this.Legs = "| |" + new string(' ', 15) + "/ /" + Environment.NewLine
                     + "| |" + new string(' ', 14) + "/ /" + Environment.NewLine
                     + "| |" + new string(' ', 11) + "__/ /" + Environment.NewLine
                     + "| |" + new string(' ', 10) + "|____|";
        }

        public void DrawLeftArm()
        {
            this.Neck = "| |" + new string(' ', 15) + "____|  |__";

            this.Body = "| |" + new string(' ', 14) + "/ " + "/" + new string(' ', 8) + "\\" + Environment.NewLine
                     + "| |" + new string(' ', 13) + "/ /" + "|" + new string(' ', 8) + "|" + Environment.NewLine
                     + "| |" + new string(' ', 12) + "/ /" + " |" + new string(' ', 8) + "|" + Environment.NewLine
                     + "| |" + new string(' ', 11) + "/ /" + "  |" + new string(' ', 8) + "|" + Environment.NewLine
                     + "| |" + new string(' ', 10) + "/|||\\" + " |" + new string(' ', 8) + "|" + Environment.NewLine
                     + "| |" + new string(' ', 16) + "\\" + new string('_', 8) + "/";
        }

        public void DrawRightArm()
        {
            this.Neck = "| |" + new string(' ', 15) + "____|  |____";

            this.Body = "| |" + new string(' ', 14) + "/ " + "/" + new string(' ', 8) + "\\" + " \\" + Environment.NewLine
                     + "| |" + new string(' ', 13) + "/ /" + "|" + new string(' ', 8) + "|" + "\\ \\" + Environment.NewLine
                     + "| |" + new string(' ', 12) + "/ /" + " |" + new string(' ', 8) + "|" + " \\ \\" + Environment.NewLine
                     + "| |" + new string(' ', 11) + "/ /" + "  |" + new string(' ', 8) + "|" + "  \\ \\" + Environment.NewLine
                     + "| |" + new string(' ', 10) + "/|||\\" + " |" + new string(' ', 8) + "|" + " /|||\\" + Environment.NewLine
                     + "| |" + new string(' ', 16) + "\\" + new string('_', 8) + "/";
        }


        public Drawer()
        {
            this.Head = "| |" + Environment.NewLine
                      + "| |" + Environment.NewLine
                      + "| |" + Environment.NewLine
                      + "| |";

            this.Neck = "| |";

            this.Body = "| |" + Environment.NewLine +
                "| |" + Environment.NewLine +
                "| |" + Environment.NewLine +
                "| |" + Environment.NewLine +
                "| |" + Environment.NewLine +
                "| |";

            this.Legs = "| |" + Environment.NewLine
                      + "| |" + Environment.NewLine
                      + "| |" + Environment.NewLine
                      + "| |";
        }
    }
}