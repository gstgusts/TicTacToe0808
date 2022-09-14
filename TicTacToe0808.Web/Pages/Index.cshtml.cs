using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TicTacToe0808.Data;

namespace TicTacToe0808.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //private Game _game;

        public Game TicTacToe { get; set; }

        public string Message { get; set; }

        public string CellClicked { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            //_game = new Game();

            TicTacToe = Program.Game;
        }

        public void OnGet()
        {
            var restart = Request.Query["restart"];

            if(restart == "y")
            {
                TicTacToe.Reset();
                return;
            }
            
            var a = Request.Query["id"];
            CellClicked = a.ToString();

            if(!string.IsNullOrEmpty(CellClicked))
            {
                var parts = CellClicked.Split(',');
                var rowIndex = int.Parse(parts[0]);
                var colIndex = int.Parse(parts[1]);

                var result = TicTacToe.MakeMove(rowIndex, colIndex);

                switch (result)
                {
                    case GameResultEnum.Draw:
                        //UIHelper.PrintResult("It's a draw!");
                        Message = "It's a draw!";
                        break;
                    case GameResultEnum.XWon:
                        //UIHelper.PrintResult("X is the winner!");
                        Message = "X is the winner!";
                        break;
                    case GameResultEnum.OWon:
                        //UIHelper.PrintResult("O is the winner!");
                        Message = "O is the winner!";
                        break;
                }
            }
        }
    }
}