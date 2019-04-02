using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanConstructor
{
    class Mahasiswa
    {
        // construktor default
        public Mahasiswa()
        {

        }

        // construktor dengan 2 parameter
        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;
        }

        // properties
        public string Nim { get; set; }
        public string Nama { get; set; }
    }
}
