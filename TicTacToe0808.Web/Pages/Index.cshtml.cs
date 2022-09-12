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

        public string CellClicked { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            //_game = new Game();

            TicTacToe = new Game();
        }

        public void OnGet()
        {
            var a = Request.Query["id"];

            CellClicked = a.ToString();
        }
    }
}