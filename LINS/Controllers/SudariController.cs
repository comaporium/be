using Microsoft.AspNetCore.Mvc;
using LINS.Models;

namespace sudari.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class SudariController : Controller
    {
        LinsContext db = new LinsContext();

        [HttpGet("{nadleznost}")]
        public IActionResult sviSudari(string nadleznost)
        {
            List<Sudari> sviSudari = db.Sudaris.Where(x => x.PolicijskaNadleznost.Equals(nadleznost)).OrderBy(x=> x.DatumNastankaSaobracajneNezgode).ToList();
            return Ok(sviSudari);
        }

        [HttpGet("{id}")]
        public IActionResult sudarPoIDu(int id)
        {
            Sudari sudar = db.Sudaris.Where(x => x.Fid == id).FirstOrDefault();
            if(sudar == null) return NotFound("Sudar sa tim IDem ne postoji u bazi");

            return Ok(sudar);
        }
    }
}
