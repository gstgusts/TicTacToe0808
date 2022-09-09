using TicTacToe0808.Data;

namespace TicTacToe0808.Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            while(true)
            {
                UIHelper.DrawBoard(game.Field);

                Console.Write("Please enter row and column (enter comma seperated values): ");
                var userInput = Console.ReadLine();

                var values = userInput.Split(",", StringSplitOptions.TrimEntries);

                var rowIndex = int.Parse(values[0]);
                var columnIndex = int.Parse(values[1]);

                var result = game.MakeMove(rowIndex, columnIndex);

                switch (result)
                {
                    case GameResultEnum.Duece:
                        break;
                    case GameResultEnum.XWon:
                        break;
                    case GameResultEnum.OWon:
                        break;
                }
            }
        }
    }
}