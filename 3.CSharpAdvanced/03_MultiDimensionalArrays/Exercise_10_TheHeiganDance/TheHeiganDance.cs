using System;

namespace Exercise_10_TheHeiganDance
{
    public class TheHeiganDance
    {
        public static void Main(string[] args)
        {
            SettingUpTheRaid();
        }

        //Sets up the came field and players health.
        public static void SettingUpTheRaid()
        {
            var gameField = new bool[15][];

            for (var row = 0; row < gameField.Length; row++)
            {
                gameField[row] = new bool[15];
            }

            Player player = new Player();
            player.PlayerDamage = double.Parse(Console.ReadLine());

            Heigan heigan = new Heigan();

            ReceiveTurnInformation(player, heigan, gameField);
        }

        //Receives input from the console.
        public static void ReceiveTurnInformation(Player player, Heigan heigan, bool[][] gameField)
        {
            while (player.PlayerHealth > 0 && heigan.HeiganHealth > 0)
            {
                if (heigan.HeiganHealth - player.PlayerDamage > 0)
                {
                    heigan.HeiganHealth -= player.PlayerDamage;
                    var turnInformation = Console.ReadLine().Split(' ');

                    if (heigan.CloudTimer > 0)
                    {
                        player.PlayerHealth -= heigan.PlagueCloud;
                        heigan.CloudTimer--;

                        if (player.PlayerHealth <= 0 && player.PlayerStatus == "Player: ")
                        {
                            player.PlayerStatus = "Player: Killed by Plague Cloud";
                            heigan.HeiganStatus = $"Heigan: {String.Format("{0:0.00}", heigan.HeiganHealth)}";
                        }
                    }

                    ExecuteAttack(turnInformation, gameField, player, heigan);
                }
                else if (heigan.HeiganHealth - player.PlayerDamage <= 0 && player.PlayerStatus == "Heigan: ")
                {
                    heigan.HeiganHealth = 0;
                    heigan.HeiganStatus = "Heigan: Defeated!";
                    player.PlayerStatus = $"Player: {player.PlayerHealth}";
                    break;
                }

                for (var index = 0; index < gameField.Length; index++)
                {
                    for (var innerIndex = 0; innerIndex < gameField[index].Length; innerIndex++)
                    {
                        if (gameField[index][innerIndex] == true)
                        {
                            gameField[index][innerIndex] = false;
                        }
                    }
                }
            }

            PrintResults(heigan, player);
        }

        //Executes the different Heigan attacks
        static void ExecuteAttack(string[] turnInformation, bool[][] gameField, Player player, Heigan heigan)
        {
            var spell = turnInformation[0];
            var attackRow = int.Parse(turnInformation[1]);
            var attackCol = int.Parse(turnInformation[2]);
            var counter = 9;

            while (counter > 0)
            {
                for (var ind = 0; ind < 3; ind++)
                {
                    for (var secondaryInd = 0; secondaryInd < 3; secondaryInd++)
                    {
                        if (attackRow - 1 + ind >= 0 && attackRow - 1 + ind < 15 && attackCol - 1 + secondaryInd >= 0 && attackCol - 1 + secondaryInd < 15)
                        {
                            gameField[attackRow - 1 + ind][attackCol - 1 + secondaryInd] = true;
                            counter--;
                        }
                        else
                        {
                            counter--;
                        }
                    }
                }
            }

            switch (spell)
            {
                case "Cloud":
                    ExecuteCloudAttack(attackRow, attackCol, gameField, player, heigan);
                    break;
                case "Eruption":
                    ExecuteEruptionAttack(attackRow, attackCol, gameField, player, heigan);
                    break;
            }
        }

        //Executes the cloud attack.
        static void ExecuteCloudAttack(int attackRow, int attackCol, bool[][] gameField, Player player, Heigan heigan)
        {
            if (player.PlayerRow == attackRow && player.PlayerCol == attackCol)
            {
                player.PlayerHealth -= heigan.PlagueCloud;
                heigan.CloudTimer = 1;
            }
            else if (gameField[player.PlayerRow][player.PlayerCol] == true)
            {
                try
                {
                    if (gameField[player.PlayerRow - 1][player.PlayerCol] == true || player.PlayerRow - 1 < 0)
                    {
                        if (gameField[player.PlayerRow][player.PlayerCol + 1] == true || player.PlayerCol + 1 == 15)
                        {
                            if (gameField[player.PlayerRow + 1][player.PlayerCol] == true || player.PlayerRow + 1 == 15)
                            {
                                if (gameField[player.PlayerRow][player.PlayerCol - 1] == true || player.PlayerCol - 1 < 0)
                                {
                                    player.PlayerHealth -= heigan.PlagueCloud;
                                    heigan.CloudTimer = 1;
                                }
                                else
                                {
                                    player.PlayerCol--;
                                }
                            }
                            else
                            {
                                player.PlayerRow++;
                            }
                        }
                        else
                        {
                            player.PlayerCol++;
                        }
                    }
                    else
                    {
                        player.PlayerRow--;
                    }
                }
                catch
                {
                    player.PlayerHealth -= heigan.PlagueCloud;
                    heigan.CloudTimer = 1;
                }
            }

            if (player.PlayerHealth <= 0 && player.PlayerStatus == "Player: ")
            {
                player.PlayerStatus = "Player: Killed by Plague Cloud";
                heigan.HeiganStatus = $"Heigan: {String.Format("{0:0.00}", heigan.HeiganHealth)}";
            }
        }

        //Executes the eruption attack.
        static void ExecuteEruptionAttack(int attackRow, int attackCol, bool[][] gameField, Player player, Heigan heigan)
        {
            if (player.PlayerRow == attackRow && player.PlayerCol == attackCol)
            {
                player.PlayerHealth -= heigan.Eruption;
            }
            else if (gameField[player.PlayerRow][player.PlayerCol] == true)
            {
                try
                {
                    if (gameField[player.PlayerRow - 1][player.PlayerCol] == true || player.PlayerRow - 1 < 0)
                    {
                        if (gameField[player.PlayerRow][player.PlayerCol + 1] == true || player.PlayerCol + 1 == 15)
                        {
                            if (gameField[player.PlayerRow + 1][player.PlayerCol] == true || player.PlayerRow + 1 == 15)
                            {
                                if (gameField[player.PlayerRow][player.PlayerCol - 1] == true || player.PlayerCol - 1 < 0)
                                {
                                    player.PlayerHealth -= heigan.Eruption;
                                }
                                else
                                {

                                    player.PlayerCol--;
                                }
                            }
                            else
                            {
                                player.PlayerRow++;
                            }
                        }
                        else
                        {
                            player.PlayerCol++;
                        }
                    }
                    else
                    {
                        player.PlayerRow--;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    player.PlayerHealth -= heigan.Eruption;
                }
            }

            if (player.PlayerHealth <= 0 && player.PlayerStatus == "Player: ")
            {
                player.PlayerStatus = "Player: Killed by Eruption";
                heigan.HeiganStatus = $"Heigan: {String.Format("{0:0.00}", heigan.HeiganHealth)}";
            }
        }

        //Prints the final result of the game on the console.
        static void PrintResults(Heigan heigan, Player player)
        {
            Console.WriteLine(heigan.HeiganStatus);
            Console.WriteLine(player.PlayerStatus);
            Console.WriteLine($"Final position: {player.PlayerRow}, {player.PlayerCol}");
        }
    }


    //Creates object player that holds the stats of the player and his position on the field.
    public class Player
    {
        private double playerHealth = 18500;
        private int playerRow = 7;
        private int playerCol = 7;
        private double playerDamage;
        private string playerStatus = "Player: ";

        public string PlayerStatus
        {
            get
            {
                return this.playerStatus;
            }
            set
            {
                this.playerStatus = value;
            }
        }

        public double PlayerHealth
        {
            get
            {
                return this.playerHealth;
            }
            set
            {
                this.playerHealth = value;
            }
        }

        public int PlayerRow
        {
            get
            {
                return this.playerRow;
            }
            set
            {
                this.playerRow = value;
            }
        }

        public int PlayerCol
        {
            get
            {
                return this.playerCol;
            }
            set
            {
                this.playerCol = value;
            }
        }

        public double PlayerDamage
        {
            get
            {
                return this.playerDamage;
            }
            set
            {
                this.playerDamage = value;
            }
        }

        public Player()
        {
            this.PlayerHealth = playerHealth;
            this.PlayerRow = playerRow;
            this.PlayerCol = playerRow;
            this.PlayerDamage = playerDamage;
            this.PlayerStatus = playerStatus;
        }
    }

    //Creates object heigan that holds the stats of the Heigan.
    public class Heigan
    {
        private double heiganHealth = 3000000;
        private double eruption = 6000;
        private double plagueCloud = 3500;
        private string heiganStatus = "Heigan: ";
        private int cloudTimer = 0;

        public int CloudTimer
        {
            get
            {
                return this.cloudTimer;
            }
            set
            {
                this.cloudTimer = value;
            }
        }

        public string HeiganStatus
        {
            get
            {
                return this.heiganStatus;
            }
            set
            {
                this.heiganStatus = value;
            }
        }

        public double HeiganHealth
        {
            get
            {
                return this.heiganHealth;
            }
            set
            {
                this.heiganHealth = value;
            }
        }

        public double PlagueCloud
        {
            get
            {
                return this.plagueCloud;
            }
            set
            {
                this.plagueCloud = value;
            }
        }

        public double Eruption
        {
            get
            {
                return this.eruption;
            }
            set
            {
                this.eruption = value;
            }
        }

        public Heigan()
        {
            this.HeiganHealth = heiganHealth;
            this.Eruption = eruption;
            this.PlagueCloud = plagueCloud;
            this.HeiganStatus = heiganStatus;
            this.CloudTimer = cloudTimer;
        }
    }
}