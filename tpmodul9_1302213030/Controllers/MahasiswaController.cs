using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302213030.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> ListMhs = new List<Mahasiswa>
        {
            new Mahasiswa ("Novita Sabila Nugraha", "1302213030"),
            new Mahasiswa ("Aisha Putri Nuryan", "1302213038"),
            new Mahasiswa ("Jean Rika Haryadi", "1302210004"),
            new Mahasiswa ("Jannatin Nurrohmah", "1302213051"),
            new Mahasiswa ("Muthia Khairunnisa", "1302213062")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMhs;
        }

        [HttpGet("{id}")]

        public Mahasiswa Get(int id)
        {
            return ListMhs[id];
        }

        [HttpPost]

        public void Post(Mahasiswa mahasiswa)
        {
            ListMhs.Add(mahasiswa);
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            ListMhs.RemoveAt(id);
        }
    }
}
