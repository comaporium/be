using Microsoft.AspNetCore.Mvc;
using LINS.Models;

namespace ostalo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class OstaloController : Controller
    {
        LinsContext db = new LinsContext();

        [HttpGet]
        public IActionResult getAmbijentalnePrilike()
        {
            List<VwAmbijentalnePrilike> ap = db.VwAmbijentalnePrilikes.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getBrojniProsjeci()
        {
            VwBrojniProsjeci ap = db.VwBrojniProsjecis.First();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getDaniUSedmici()
        {
            List<VwDaniUsedmici> ap = db.VwDaniUsedmicis.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getIzvoriPodataka()
        {
            List<VwIzvorPodataka> ap = db.VwIzvorPodatakas.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getKategorijaSaobracajnice()
        {
            List<VwKategorijaSaobracajnice> ap = db.VwKategorijaSaobracajnices.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getNazivMikrolokacije()
        {
            List<VwNazivMikrolokacije> ap = db.VwNazivMikrolokacijes.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getNazivUlice()
        {
            List<VwNazivUlice> ap = db.VwNazivUlices.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getOznakeSaobracajnice()
        {
            List<VwOznakaSaobracajnice> ap = db.VwOznakaSaobracajnices.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getPadavine()
        {
            List<VwPadavine> ap = db.VwPadavines.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getPeriodDana()
        {
            List<VwPeriodDana> ap = db.VwPeriodDanas.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getPolicijskeNadleznosti()
        {
            List<VwPolicijskaNadleznost> ap = db.VwPolicijskaNadleznosts.Where(x => !x.PolicijskaNadleznost.Equals("PU Novi Grad\nPS Novi Grad, PS Dobrinja, PO Rajlovac")).OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getStanjeKolovoza()
        {
            List<VwStanjeKolovoza> ap = db.VwStanjeKolovozas.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getVidljivost()
        {
            List<VwVidljivost> ap = db.VwVidljivosts.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }

        [HttpGet]
        public IActionResult getVrstaSaobNezgode()
        {
            List<VwVrstaSaobracajneNezgode> ap = db.VwVrstaSaobracajneNezgodes.OrderByDescending(x => x.Kolicina).ToList();
            return Ok(ap);
        }
    }
}
