using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculater.Models;

namespace Calculater.OCR.Methods
{
    public static class ReadOCR
    {

        public static Equation Read(ImageFile file)
        {
            Random rnd = new Random();
            return new Equation { A = rnd.Next(0, 15), B = rnd.Next(0, 15), C = rnd.Next(0, 99) };
        }
    }
}
