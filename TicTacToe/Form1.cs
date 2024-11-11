/*
 * Program ID: TicTacToe
 * 
 * Purpose: To create the best Tic Tac Toe game
 * 
 * Revision History:
 *		Krishan Singh created September 28, 2024
 *		Krishan Singh modified September 29, 2024
 */
namespace TicTacToe
{
    public partial class formTicTacToe : Form
    {
        // Setting starting choice(X)
        private char currentChoice = 'X';
        private int turnsPlayed = 0;

        private void RestartGame()
        {
            // Clear picture boxes
            foreach (Control c in Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = null;
                    pb.Name = pb.Name.Remove(3); // Removes X or O prefix from the name of picture box
                    pb.Enabled = true; // Again enabling all the PictureBoxes
                }
            }

            // Setting current choice back to 'X'
            currentChoice = 'X';
            turnsPlayed = 0;
        }

        // Get the picture path based on current choice
        private Bitmap GetCurrentImage()
        {
            return (currentChoice == 'X') ?
                Properties.Resources.X :
                Properties.Resources.O;
        }

        private bool checkMatch(int[,] pattern)
        {
            // Create a 3D array to store all the possible winning match cases 
            int[,,] matchCases =
            {
				// Rows
				{
                    {1, 1, 1 },
                    {0, 0, 0 },
                    {0, 0, 0 },
                },
                {

                    {0, 0, 0 },
                    {1, 1, 1 },
                    {0, 0, 0 },

                },
                {
                    {0, 0, 0 },
                    {0, 0, 0 },
                    {1, 1, 1 },
                },

					// Columns
				{
                    {1, 0, 0 },
                    {1, 0, 0 },
                    {1, 0, 0 },
                },
                {
                    {0, 1, 0 },
                    {0, 1, 0 },
                    {0, 1, 0 },
                },
                {
                    {0, 0, 1 },
                    {0, 0, 1 },
                    {0, 0, 1 },
                },

					// Diagonals
				{
                    {1, 0, 0 },
                    {0, 1, 0 },
                    {0, 0, 1 },
                },

                {
                    {0, 0, 1 },
                    {0, 1, 0 },
                    {1, 0, 0 },
                }
            };

            for (int i = 0; i < matchCases.GetLength(0); i++)
            {
                bool matching = true;
                for (int row = 0; row < matchCases.GetLength(1); row++)
                {
                    for (int col = 0; col < matchCases.GetLength(2); col++)
                    {
                        if (matchCases[i, row, col] != pattern[row, col]
                         && matchCases[i, row, col] == 1)
                        {
                            matching = false;
                            break;
                        }
                    }
                    // Break the whole loop if even one element is unmatched and move on to the next case
                    if (!matching)
                    {
                        break;
                    }
                }
                // Check if this match case matched the pattern
                if (matching) return true;
            }
            return false;
        }

        private int[,] createPattern(char symbol)
        {
            int[,] pattern = new int[3, 3];
            int patternRow = 0;
            int patternCol = 0;

            foreach (Control pb in Controls)
            {
                // The array gets created in reverse order but it does not matter because if there is a match, it is still going to be shown in the array
                if (pb is PictureBox)
                {
                    if (pb.Name.EndsWith(symbol)) pattern[patternRow, patternCol] = 1;
                    else pattern[patternRow, patternCol] = 0;
                    if (patternCol++ == 2) { patternRow++; patternCol = 0; }
                }
            }
            return pattern;
        }
        private void UpdateBox(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.Enabled = false;
            turnsPlayed++;
            // Changing the currentChoice because it will change every time this function is called to set the choice
            box.Image = GetCurrentImage();
            box.Name += currentChoice; // Adds the symbol which the current box is holding to its name
                                       // Game Logic
            if (checkMatch(createPattern(currentChoice)) == true) // check for matching winning patterns
            {
                DialogResult result = MessageBox.Show($"{currentChoice} wins the game!", "Tic Tac Toe", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry) RestartGame();
                else Application.Exit();
                return;
            }
            if (turnsPlayed >= 9)
            {
                DialogResult result = MessageBox.Show($"It is a Tie!", "Tic Tac Toe", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry) RestartGame();
                else Application.Exit();
                return;
            }
            currentChoice = (currentChoice == 'X') ? 'O' : 'X';
        }
        public formTicTacToe()
        {
            InitializeComponent();
        }
    }
}