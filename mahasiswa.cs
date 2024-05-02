using System.Diagnostics.Contracts;

namespace modul8_1302220131
{
    public class Mahasiswa
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public List<string> course { get; set; }
        public int year { get; set; }

        public Mahasiswa(string nama, string nim, List<string> course, int year) { 
            this.nama = nama;
            this.nim = nim;
            this.course = course;
            this.year = year;
        }
    }
}
