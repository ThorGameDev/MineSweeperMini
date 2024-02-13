using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MineSweeperMini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // The chance any given tile is a bomb
        const int bomb_chance = 5;

        // A two demensional array containing every tile
        private object[,] image_grid;

        // A two demensional array containing the location of the bombs
        private bool[,] bombs;

        // A two demensional array containing all the spots already played
        private bool[,] played_spots;

        // An integer containing how many bombs are on the board
        private int total_bombs = 0;

        // This bool is true if it is the board has been clicked. Otherwise, it is false
        private bool first_move;

        // The ammount of time sense the first click
        private int time;



        //This is the function called by each tile when clicked. 
        //It figgures out the position you selected, and calls play_at with that position
        private void play_spot(object sender, EventArgs e)
        {
            //There is most likely a better way to do this
            int Y = 0;
            int X = 0;

            // itterates through each grid position
            for (int x = 0; x < image_grid.GetLength(0); x++)
            {
                for (int y = 0; y < image_grid.GetLength(1); y++)
                {
                    // if the button that called the function is the same as the button at this position,
                    // save the position to use latter
                    if (sender == image_grid[x, y])
                    {
                        X = x;
                        Y = y;
                    }
                }
            }

            //Run logic from the position that was previously saved
            play_at(X, Y);
        }


        //A simple utility function to check if a coordanate is within the board
        private bool in_bounds(int X, int Y)
        {
            return !(X < 0 || Y < 0 || X >= 5 || Y >= 5);
        }


        //Checks if there is a bomb where you click.
        // If so, then the game ends, and reset is called
        // otherwise, the number of neaby mines is displayed.
        // This function contains the core logic of the game
        private void play_at(int X, int Y)
        {
            if (!in_bounds(X, Y)) { return; }

            // Special logic for first move to prevent instantly clicking on a bomb
            if (first_move)
            {
                first_move = false;
                if (bombs[X, Y])
                {
                    bombs[X, Y] = false;
                    floodfill(X, Y);
                    total_bombs--;
                }
                totalBombsLabel.Text = $"Total Bombs: {total_bombs}";
                gameTimer.Start();
            }

            //Check if you have clicked a mine
            if (bombs[X, Y] == true)//Mine clicked. Game over
            {
                ((PictureBox)image_grid[X, Y]).Image = otherTiles.Images[2];//shows the mine clicked
                gameTimer.Stop();
                MessageBox.Show("You Exploded!");
                reset();
                return;
            }
            else//Mine not clicked. 
            {
                int near_bombs = get_bomb_count(X, Y);
                ((PictureBox)image_grid[X, Y]).Image = numberTiles.Images[near_bombs];//shows nearby bomb number
                if (near_bombs == 0)
                {
                    //If no bombs are nearby, unvail the entire bombless area.
                    floodfill(X, Y);
                }
                else
                {
                    played_spots[X, Y] = true;
                }
            }

            //checks if you won, then runs a victory sequence
            if (has_won())
            {
                gameTimer.Stop();
                MessageBox.Show("You Won!");
                log_win_time(time);
                reset();
            }
        }


        //If you beat the game, this function saves your time if it beats the previous best.
        public void log_win_time(int play_time)
        {
            // Sets the previous best as a placeholder
            int old_best = -1;

            // Trys to read the best time file
            try
            {
                StreamReader file;
                file = File.OpenText("best_time.txt");
                old_best = int.Parse(file.ReadToEnd());
                file.Close();
            }
            // if no the file does not exist,
            //notify the user that they won for the first time
            catch (Exception e)
            {
                MessageBox.Show("Congragulations on your first completion!");                 
            }

            //If the time is better than the old one, or no time file was found, update it
            if (old_best == -1 || time < old_best)
            {
                try
                { 
                    StreamWriter file;
                    file = new StreamWriter("best_time.txt");
                    file.Write(play_time.ToString());
                    file.Close();
                }
                //Sorry unfortunate user who enccounters this.
                //It shouldent happen, but files have a mind of their own.
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
        }


        //Checks if you have won by itterating through each tile.
        //If the number of tiles not played is the same as the number of bombs, it assumes you won.
        private bool has_won()
        {
            int uncovered = 0;

            //itterate through each tile in the board
            for (int x = 0; x < image_grid.GetLength(0); x++)
            {
                for (int y = 0; y < image_grid.GetLength(1); y++)
                {
                    // if the tile has not been played, incriment the uncovered variable
                    if (played_spots[x, y] == false)
                    {
                        uncovered++;
                    }
                }
            }
            return uncovered == total_bombs; 
            
        }


        //Checks nearby tiles to see if they contain a bomb
        private int get_bomb_count(int X, int Y)
        {
            //Note that this function depends on only being called at positions where there is atleast one bomb missing
            //Otherwise it will return 9, which results in an index out of range with the image box.
            //This is not a probolem right now, however, as it is not called on top of a bomb.


            if (!in_bounds(X, Y)) { return -1; }

            int num = 0;

            // itterates through a 3x3 square, sentered arround (0,0)
            for (int checkX = -1; checkX <= 1; checkX++)
            {
                for (int checkY = -1; checkY <= 1; checkY++)
                {
                    // Adds the square's position to the spot being checked
                    int x = checkX + X;
                    int y = checkY + Y;

                    // Do not check locations outside of the grid
                    if (!in_bounds(x, y)) { continue; }

                    // if there is a bomb, incriment the number of detected bombs
                    if (bombs[x, y] == true)
                    {
                        num++;
                    }
                }
            }
            return num;
        }


        //A recursive function to unvail nearby tiles if you chose a bombless spot
        private void floodfill(int X, int Y)
        {
            // If not ran inside of the board, quit instantly.
            if (!in_bounds(X, Y)) { return; }

            // Increadibly important to prevent an infinite loop
            if (played_spots[X,Y] == true) { return; }
            played_spots[X,Y] = true;
            
            //checks how many bombs are nearby
            int near_bombs = get_bomb_count(X,Y);

            //reviels this tile
            ((PictureBox)image_grid[X, Y]).Image = numberTiles.Images[near_bombs];

            //If still inside of the mineless patch, call this function at nearby positions
            if (near_bombs == 0)
            {
                floodfill(X+1, Y+1);
                floodfill(X, Y+1);
                floodfill(X-1, Y+1);
                floodfill(X+1, Y);
                floodfill(X, Y);
                floodfill(X-1, Y);
                floodfill(X+1, Y-1);
                floodfill(X, Y-1);
                floodfill(X-1, Y-1);
            }
        }


        //returns the program to the default state
        private void reset()
        {
            //Reassign variables that may change durring runtime
            totalBombsLabel.Text = "Total Bombs: ???";
            timeIndicator.Text = "Time: 0";
            played_spots = new bool[5, 5];
            first_move = true;
            total_bombs = 0;
            time = 0;

            //Loop through all the tiles and return their image to the default state
            for (int x = 0; x < image_grid.GetLength(0); x++)
            {
                for (int y = 0; y < image_grid.GetLength(1); y++)
                {
                    ((PictureBox)image_grid[x, y]).Image = otherTiles.Images[0];
                }
            }

            //Randomly places bombs accrossed the grid
            Random bomb_placer = new Random();
            bombs = new bool[5, 5];
            for (int x = 0; x < image_grid.GetLength(0); x++)
            {
                for (int y = 0; y < image_grid.GetLength(1); y++)
                {
                    if(bomb_placer.Next(0, bomb_chance) == 0)
                    {
                        bombs[x, y] = true;
                        total_bombs++;
                    }
                }
            }

            //Reads the best time file.
            try
            {
                StreamReader file;
                file = File.OpenText("best_time.txt");
                bestTime.Text = "Best Time: " + file.ReadToEnd();
                file.Close();
            }
            catch 
            {
                bestTime.Text = "Best Time: N/A";
            }
        }


        //Initializes the image grid and calls the reset function
        private void Form1_Load(object sender, EventArgs e)
        {
            image_grid = new object[,] { {t1_1, t1_2, t1_3, t1_4, t1_5 },
                                         {t2_1, t2_2, t2_3, t2_4, t2_5 }, 
                                         {t3_1, t3_2, t3_3, t3_4, t3_5 }, 
                                         {t4_1, t4_2, t4_3, t4_4, t4_5 }, 
                                         {t5_1, t5_2, t5_3, t5_4, t5_5} };
            reset();
        }


        //Called by the timer form object. Records how long you are taking to play
        private void timer_increment(object sender, EventArgs e)
        {
            time += 1;
            timeIndicator.Text = $"Time: {time}";
        }


        //Close the program when the exit button is pressed
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
