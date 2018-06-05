using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_operation_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new Image();
            var result = image?.ImagePath ?? string.Empty; // if image is null,it is assinging string.empty
            Console.Write(result);
            image.ImagePath = "SampleImage";
            result = image?.ImagePath ?? string.Empty; // assinging imagePath value
            Console.Write(result);
            Console.ReadKey();
        }
    }
    class Image
    {
        public string ImagePath { get; set; }
    }
}
