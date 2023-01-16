using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Polskie_Jeziora.Models;

namespace Polskie_Jeziora.Pages
{
    public class DeepestLakes : PageModel
    {
        private readonly ILogger<DeepestLakes> _logger;

        public List<LakeInfo> lakes = new List<LakeInfo>()
        {
            new LakeInfo()
            {
                Name = "Hańcza",
                Size = "108,5 m",
                Description = "Jezioro położone na Pojezierzu Wschodniosuwalskim. Najgłębsze jezioro w Polsce i w całej środkowej części Niżu Europejskiego. Najczęściej podawana w literaturze maksymalna głębokość jeziora wynosi 108,5 m (według różnych badań wynosi: 106,1 m, 111,5 m, 113 m, 105,55 m). Przepływa przez nie rzeka Czarna Hańcza.",
                Url = "https://upload.wikimedia.org/wikipedia/commons/0/08/Jezioro_Hancza%2C_Poland%2C_Aug_2004.jpg"
            },
            new LakeInfo()
            {
                Name = "Drawsko",
                Size = "79,7 m",
                Description = "Jezioro na Pojezierzu Drawskim, położone w woj. zachodniopomorskim, w powiecie drawskim, w gminie Czaplinek. Powierzchnia zwierciadła wody wynosi 1781,5 ha. Objętość wody w zbiorniku wynosi 331 443,5 tys. m³.Według publikacji z 1991 roku maksymalna głębokość wynosi 79,7 m, a średnia głębokość 17,7 m. Drawsko jest drugim jeziorem po Hańczy pod względem głębokości w Polsce.",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Jezioro_Drawsko_%281%29.jpg/240px-Jezioro_Drawsko_%281%29.jpg"
            },
            new LakeInfo()
            {
                Name = "Wielki Staw",
                Size = "79,3 m",
                Description = "największe jezioro tatrzańskie, położone w Tatrach Wysokich na wysokości 1665 m n.p.m., w Dolinie Pięciu Stawów Polskich u zboczy Miedzianego. Powierzchnia jeziora według pomiarów WIG z 1934 r. wynosi 34,14 ha, głębokość 79,3 m[3]. Nowsze sondowanie przeprowadzone przez Adama Choińskiego określiło głębokość na 80,3 m. W wielu publikacjach encyklopedycznych i przewodnikowych jako nieco większe pod względem powierzchni podawane jest (za pomiarami WIG) Morskie Oko, co jednak nie znajduje potwierdzenia we współczesnych badaniach teledetekcyjnych.",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/WielkiStawPolski.jpg/240px-WielkiStawPolski.jpg"
            }
        };
        public DeepestLakes(ILogger<DeepestLakes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}