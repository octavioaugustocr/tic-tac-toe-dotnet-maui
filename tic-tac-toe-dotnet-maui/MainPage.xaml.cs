namespace tic_tac_toe_dotnet_maui
{
    public partial class MainPage : ContentPage
    {
        string turn = "X";
        int contTurn = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var winner = "";

            Button button = (Button)sender;

            if (turn == "X")
            {
                button.Text = turn;
                button.IsEnabled = false;
                turn = "O";
                contTurn++;
            }
            else
            {
                button.Text = turn;
                button.IsEnabled = false;
                turn = "X";
                contTurn++;
            }

            winner = CheckIfAnyoneWon();
            if (winner != "")
            {
                DisplayAlert("Congratulations", winner, "OK");
                RestartGame();
            }

            if (contTurn == 9)
            {
                DisplayAlert("Alert", "Draw!", "OK");
                RestartGame();
            }
        }

        string CheckIfAnyoneWon()
        {
            string winner = "";

            // ---
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") winner = "Player X won!";
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") winner = "Player X won!";
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") winner = "Player X won!";
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") winner = "Player O won!";
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") winner = "Player O won!";
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") winner = "Player O won!";

            // |
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") winner = "Player X won!";
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") winner = "Player X won!";
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") winner = "Player X won!";
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") winner = "Player O won!";
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") winner = "Player O won!";
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") winner = "Player O won!";

            // /
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") winner = "Player X won!";
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") winner = "Player O won!";

            // \
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X") winner = "Player X won!";
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O") winner = "Player O won!";

            return winner;
        }

        void RestartGame()
        {
            contTurn = 0;

            btn10.Text = string.Empty;
            btn10.IsEnabled = true;

            btn11.Text = string.Empty;
            btn11.IsEnabled = true;

            btn12.Text = string.Empty;
            btn12.IsEnabled = true;

            btn20.Text = string.Empty;
            btn20.IsEnabled = true;

            btn21.Text = string.Empty;
            btn21.IsEnabled = true;

            btn22.Text = string.Empty;
            btn22.IsEnabled = true;

            btn30.Text = string.Empty;
            btn30.IsEnabled = true;

            btn31.Text = string.Empty;
            btn31.IsEnabled = true;

            btn32.Text = string.Empty;
            btn32.IsEnabled = true;
        }
    }

}
