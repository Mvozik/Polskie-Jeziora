using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Polskie_Jeziora.Models;

namespace Polskie_Jeziora.Pages
{
    public class BiggestLakes : PageModel
    {
        private readonly ILogger<BiggestLakes> _logger;
        public List<LakeInfo> lakes = new List<LakeInfo>()
        {
            new LakeInfo()
            {
                Name = "Śniardwy",
                Size = "113,4 km²",
                Description = "Największe jezioro w Polsce, w województwie warmińsko-mazurskim, w powiatach: mrągowskim i piskim, położone w Krainie Wielkich Jezior Mazurskich, w dorzeczu Pisy. Jest to jezioro polodowcowe. Lustro wody jest na wysokości 116 m n.p.m. W wielu miejscach płytkie dno jeziora usiane jest głazami narzutowymi, które kryją się tuż pod powierzchnią wody (20 do 30 cm pod lustrem wody) stwarzając zagrożenie w żegludze.",
                Url = "https://upload.wikimedia.org/wikipedia/commons/1/14/Sniardwy_jezioro.jpeg"
            },
            new LakeInfo()
            {
                Name = "Mamry",
                Size = "86 km²",
                Description = "Mamry to jezioro polodowcowe morenowe i drugie pod względem powierzchni jezioro w Polsce. Dno jeziora jest zróżnicowane z licznymi zagłębieniami i wypłyceniami, przy czym część północna jest wyraźnie głębsza, dno porasta roślinność wynurzona i łąki podwodne złożone z ramienic. Brzegi jeziora przeważnie niskie i podmokłe, w części porośnięte lasem.",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/Dargin.jpg/1280px-Dargin.jpg"
            },
            new LakeInfo()
            {
                Name = "Łebsko",
                Size = "71,4 km²",
                Description = "Jezioro powstało poprzez podniesienie poziomu morza i zalanie łąk. Nie było zatoką morską.Na jeziorze w sezonie wakacyjnym realizowana jest żegluga pasażerska z przystani w Rąbce. Rejsy organizowane są do Muzeum Wyrzutni Rakiet w Rąbce oraz do Muzeum Wsi Słowińskiej w Klukach. Kurs do Muzeum Wyrzutni Rakiet trwa około 20 minut i wykonywany jest codziennie co pół godziny. Rejsy do Kluk odbywają się w środy i w niedziele i trwają około półtorej godziny w jedną stronę[23]. Zakres wycieczki obejmuje dodatkowo m.in. przejazd kolejką z centrum Łeby do Rąbki oraz zwiedzanie muzeum z przewodnikiem.",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/%C5%81ebsko_jezioro.jpg/1280px-%C5%81ebsko_jezioro.jpg"
            }
        };

        public BiggestLakes(ILogger<BiggestLakes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}