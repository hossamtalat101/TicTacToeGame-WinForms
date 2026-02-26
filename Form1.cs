namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        bool isPlayer1Turn = true;
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
            btnRestart_Click(null, null);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "?") return;

            if (isPlayer1Turn)
            {
                btn.Text = "X";
                btn.ForeColor = Color.LightBlue;
                lblStatus.Text = "Player 2";
            }
            else
            {
                btn.Text = "O";
                btn.ForeColor = Color.Plum;
                lblStatus.Text = "Player 1";
            }

            turnCount++;
            CheckForWinner();
            isPlayer1Turn = !isPlayer1Turn;
        }

        private void CheckForWinner()
        {
            bool thereIsAWinner = false;

            if (CheckThree(btnTopLeft, btnTopMiddle, btnTopRight)) 
                thereIsAWinner = true;
            else if (CheckThree(btnMiddleLeft, btnCenter, btnMiddleRight)) 
                thereIsAWinner = true;
            else if (CheckThree(btnBottomLeft, btnBottomMiddle, btnBottomRight)) 
                thereIsAWinner = true;

            else if (CheckThree(btnTopLeft, btnMiddleLeft, btnBottomLeft)) 
                thereIsAWinner = true;
            else if (CheckThree(btnTopMiddle, btnCenter, btnBottomMiddle)) 
                thereIsAWinner = true;
            else if (CheckThree(btnTopRight, btnMiddleRight, btnBottomRight)) 
                thereIsAWinner = true;

            else if (CheckThree(btnTopLeft, btnCenter, btnBottomRight)) 
                thereIsAWinner = true;
            else if (CheckThree(btnTopRight, btnCenter, btnBottomLeft)) 
                thereIsAWinner = true;

            if (thereIsAWinner)
            {
                string winnerName = (isPlayer1Turn ? "Player 1" : "Player 2");

                lblWinner.Text = winnerName;     
                lblStatus.Text = "Game Over";    
                lblStatus.ForeColor = Color.Red;

                MessageBox.Show("Game Over! Winner is: " + winnerName);
                DisableAllButtons();
            }
            else if (turnCount == 9)
            {
                lblWinner.Text = "Draw";
                lblStatus.Text = "Game Over";
                MessageBox.Show("It's a Draw!");
            }
        }

        private bool CheckThree(Button b1, Button b2, Button b3)
        {
            if (b1.Text != "?" && b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text)
            {
                b1.BackColor = b2.BackColor = b3.BackColor = Color.LawnGreen;
                return true;
            }
            return false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            isPlayer1Turn = true;
            turnCount = 0;

            lblStatus.Text = "Player 1";    
            lblStatus.ForeColor = Color.Lime;
            lblWinner.Text = "In Progress";

            foreach (Control c in this.panel1.Controls)
            {
                if (c is Button && c.Name != "btnRestart") 
                {
                    c.Text = "?";
                    c.BackColor = Color.Black;
                    c.ForeColor = Color.Tomato;
                    c.Enabled = true;
                }
            }
        }

        private void DisableAllButtons()
        {
            foreach (Control c in this.panel1.Controls)
            {
                if (c is Button && c.Name != "btnRestart")
                {
                    c.Enabled = false;
                }
            }
        }
    }
}
