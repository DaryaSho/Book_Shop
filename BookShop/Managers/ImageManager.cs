using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Managers.Interfaces;

namespace BookShop.Managers
{
    public class ImageDescription
    {
        public byte[] Bytes { get; set; }
        public string Extension { get; set; }
    }
    public class ImageManager : IImageManager
    {
        public ImageDescription ConvertImage(string base64)
        {
            var parts = base64.Split(";base64,");
            if (parts.Length < 2)
            {
                throw new Exception("Base64 string is expected");
            }
            ImageDescription result = new ImageDescription();
            var base64String = parts[1];
            result.Extension = "." + parts[0].Split("data:image/")[1];
            if (base64String == null || base64String.Length == 0 || base64String.Length % 4 != 0
                || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
            {
                throw new Exception("Base64 string is expected");
            }
            result.Bytes = Convert.FromBase64String(base64String);

            return result;
        }
    }
}
