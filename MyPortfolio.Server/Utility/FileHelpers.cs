using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Server.Utility
{
    public class FileHelpers
    {
        /// <summary>
        /// Upload files to storage
        /// </summary>
        /// <param name="WebRootPath">Base webroot</param>
        /// <param name="files">Collection of IFormFiles to upload</param>
        /// <param name="folder">The folder to upload the files to</param>
        /// <returns></returns>
        public static string[]? UploadFiles(string WebRootPath, IFormFileCollection files, string folder)
        {
            var count = files.Count;
            string[] filepaths = new string[count];

            if (count > 0)
            {
                // create a unique name identifier for image name
                string fileName = Guid.NewGuid().ToString();
                // create variable to hold a path to folder
                var uploads = Path.Combine(WebRootPath, folder);

                for (int i = 0; i < count; i++)
                {
                    // get and preserve ext type
                    var extenstion = Path.GetExtension(files[i].FileName);

                    // create full path 
                    var fullpath = uploads + fileName + extenstion;

                    // stream the binary files to server
                    var filestream = System.IO.File.Create(fullpath);

                    files[0].CopyTo(filestream);
                    filestream.Close();

                    filepaths[i] = @"\" + folder + fileName + extenstion;
                }

                return filepaths;
            }

            return null;
        }

        /// <summary>
        /// Delete a file from storage
        /// </summary>
        /// <param name="WebRootPath">Base root</param>
        /// <param name="filepath">The filepath for the file to delete</param>
        /// <returns></returns>
        public static bool DeleteFile(string WebRootPath, string? filepath)
        {
            // create original file path
            var file = (filepath != null) ? Path.Combine(WebRootPath, filepath.TrimStart('\\')) : null;

            // delete if it exists
            if (System.IO.File.Exists(file))
            {
                System.IO.File.Delete(file);
                return true;
            }

            return false;
        }
    }
}
