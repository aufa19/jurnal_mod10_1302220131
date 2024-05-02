using Microsoft.AspNetCore.Mvc;

namespace modul8_1302220131.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Abdillah Aufa Taqiyya", "1302220131", new List<string>{"konstruksi perangkat lunak", "basis data", "pemrogramana berorientasi objek"}, 2024),
            new Mahasiswa("Irvan Dzawin Nuha", "1302220072", new List<string>{"konstruksi perangkat lunak", "basis data", "pemrogramana berorientasi objek"}, 2024),
            new Mahasiswa("Mohammed Yousef Gumilar", "1302220085", new List<string>{"konstruksi perangkat lunak", "basis data", "pemrogramana berorientasi objek"}, 2024),
            new Mahasiswa("Joshua Daniel Simanjuntak", "1302220077", new List<string>{"konstruksi perangkat lunak", "basis data", "pemrogramana berorientasi objek"}, 2024),
            new Mahasiswa("Rakha Galih Nugraha Sukma", "1302223118", new List<string>{"konstruksi perangkat lunak", "basis data", "pemrogramana berorientasi objek"}, 2024),
        };


        [HttpGet(Name = "getMahasiswa")]
        public IEnumerable<modul8_1302220131.Mahasiswa> Get()
        {
            return mahasiswa;
        }

        [HttpPost]
        public void Post([FromBody]Mahasiswa m)
        {
            mahasiswa.Add(m);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }

        [HttpDelete("{id}")]
        public void GetDelete(int id)
        {
            mahasiswa.RemoveAt(id);
        }

    }
}
