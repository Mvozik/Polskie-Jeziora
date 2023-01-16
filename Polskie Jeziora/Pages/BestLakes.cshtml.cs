using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Polskie_Jeziora.Models;

namespace Polskie_Jeziora.Pages
{
    public class BestLakes : PageModel
    {
        public List<LakeInfo> lakes = new List<LakeInfo>()
        {
            new LakeInfo()
            {
                Name = "Jezioro Solińskie",
                Size = "22 km²",
                Description = "Pierwszy projekt zagospodarowania hydroenergetycznego Sanu poprzez budowę zapory wodnej opracował w 1921 r. prof. Karol Pomianowski z Politechniki Warszawskiej (wcześniej: Politechniki Lwowskiej). Pierwsze rozpoznanie geologiczno-hydrologiczne w dolinie Sanu przeprowadzono jednak dopiero w latach 1936–1937, a dalsze prace przerwała II wojna światowa. Nowa koncepcja zabudowy doliny Sanu powstała w roku 1955 pod kierownictwem inż. Bolesława Kozłowskiego. Na miejsce wzniesienia zapory wybrano przewężenie doliny poniżej ujścia Solinki do Sanu, koło wsi Solina. Podczas napełniania zbiornika, zatopione zostały wsie Solina, Teleśnica Sanna, Horodek, Sokole, Chrewt i duża część Wołkowyi.",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Soli%C5%84skie_Lake%2C_view_to_S%2C_San_river%2C_Subcarpathian_Voivodeship%2C_Poland.jpg/1920px-Soli%C5%84skie_Lake%2C_view_to_S%2C_San_river%2C_Subcarpathian_Voivodeship%2C_Poland.jpg"
            },
            new LakeInfo()
            {
                Name = "Jezioro Piaseczno na Pojezierzu Łęczycko-Włodawskim",
                Size = "0,86 km²",
                Description = "Położone na terenie pojezierza Łęczycko-Włodawskiego Jezioro Piaseczno słynie przede wszystkim z jakości wody. Dobra widoczność przyciąga również wielu nurków. Podczas nurkowania na piaszczystym dnie można odkryć sporo pozostałości po  II wojnie światowej, jak choćby legendarny samolot Junkers.",
                Url = "https://www.interhome.pl/upload/travelguide/5417/responsive-images/4-polska-najpiekniejsze-jeziora-piaseczno___responsive-content_836_557.jpg"
            },
            new LakeInfo()
            {
                Name = "Jezioro Czorsztyńskie w Kotlinie Nowotarskiej",
                Size = "11 km²",
                Description = "Jedno z najpiękniejszych jezior w Polsce zostało sztucznie stworzone i co roku przyciąga wielu turystów. Dwa zamki na brzegach są popularnymi atrakcjami turystycznymi dla całej rodziny. Naprawdę warto odwiedzić ruiny zamku w Czorsztynie i podziwiać krajobrazy podczas rejsu statkiem do dobrze zachowanego zamku w Niedzicy. Można też podziwiać Górę Wdżar, która zimą idealnie nadaje się do jazdy na nartach z widokiem na wodę.",
                Url = "https://www.interhome.pl/upload/travelguide/5416/responsive-images/3-polska-najpiekniejsze-jeziora-czorsztyn___responsive-content_836_536.jpg"
            }
        };

        private readonly ILogger<BestLakes> _logger;

        public BestLakes(ILogger<BestLakes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}