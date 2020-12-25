using System;
using System.Collections.Generic;
using System.Linq;
using Calculater.Models;

namespace Calculater.Database
{
    public class Database
    {
        public IEnumerable<ImageFile> ImageFiles =>
            new List<ImageFile>()
            {
                new ImageFile() {FileName = "image1.png"},
                new ImageFile() {FileName = "image2.png"},
                new ImageFile() {FileName = "image3.png"},
                new ImageFile() {FileName = "image4.png"},
            }.AsEnumerable();
    }
}
