using System;

namespace Calculater.Models
{
    public class ImageFile
    {
        public ImageFile()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now; ;
        }
        public Guid Id { get; }
        public string FileName { get; set; }

        public DateTime CreateDate { get; }
    }
}
