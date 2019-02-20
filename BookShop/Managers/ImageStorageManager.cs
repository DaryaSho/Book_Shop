using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Dtos.Misc;
using BookShop.Managers.Interfaces;
using BookShop.Models;
using Microsoft.AspNetCore.Hosting;

namespace BookShop.Managers
{
    public class ImageStorageManager : IImageStorageManager
    {
        const string TempFolder = "TempPhotos";
        const string Folder = "Photos";
        string tempFolderPath = "";
        string folderPath = "";
        string root = "";
        IImageManager manager;

        public ImageStorageManager(IHostingEnvironment env, IImageManager m)
        {
            manager = m;
            root = env.WebRootPath;
            tempFolderPath = Path.Combine(root, TempFolder);
            folderPath = Path.Combine(root, Folder);
            CreateFoldersIfNeed();
        }

        private void CreateFoldersIfNeed()
        {
            if (!Directory.Exists(tempFolderPath))
            {
                Directory.CreateDirectory(tempFolderPath);
            }
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private string GetFileName()
        {
            return Path.GetRandomFileName().Split(".")[0];
        }

        public ImageDto CreateTempFiles(ImageDto dto)
        {
            var name = GetFileName();
            return new ImageDto()
            {
                Original = CreateTempFile(dto.Original, name),
                Title = dto.Title
               // Cropped = CreateTempFile(dto.Cropped, name, "_cropped")
            };
        }

        private string CreateTempFile(string base64, string name, string suffix = "")
        {
            var image = manager.ConvertImage(base64);
            var tempName = Path.Combine(tempFolderPath, name + suffix + image.Extension);
            File.WriteAllBytes(tempName, image.Bytes);
            return Path.Combine(TempFolder, name + suffix + image.Extension);
        }

        public ImageDto CreateTempFile(string base64)
        {
            var name = GetFileName();
            return new ImageDto() { Original = CreateTempFile(base64, name) };
        }

        public ImageDto MoveToPersistentLocation(ImageDto dto)
        {
            return new ImageDto()
            {
                Original = MoveToPersistentLocation(dto.Original),
                Title = dto.Title
               // Cropped = MoveToPersistentLocation(dto.Cropped)
            };
        }

        public string MoveToPersistentLocation(string name)
        {
            var fileName = name.Split(TempFolder)[1].Split("\\")[1];
            var persistent = Path.Combine(folderPath, fileName);
            var path = Path.Combine(root, name);
            File.Copy(path, persistent);
            File.Delete(path);
            return Path.Combine(Folder, fileName);
        }

        public Image OverwritePersistentLocation(Image src, Image dst)
        {
            return new Image()
            {
                Original = OverwritePersistentLocation(src.Original, dst.Original),
                Title = src.Title
               // Cropped = OverwritePersistentLocation(src.Cropped, dst.Cropped)
            };
        }

        private string OverwritePersistentLocation(string name, string dts)
        {
            var path = Path.Combine(root, name);
            var persPath = Path.Combine(root, dts);
            File.Copy(path, persPath, true);
            File.Delete(path);
            return dts;

        }
    }
}
