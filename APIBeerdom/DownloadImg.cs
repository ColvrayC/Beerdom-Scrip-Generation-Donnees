using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBeerdom
{
    public class DownloadImg
    {

        public DownloadImg()
        {

        }

        public void start(string url)
        {
            System.Drawing.Image image = DownloadImageFromUrl(url);

            FileInfo file = new FileInfo(Const.PathContent);
            file.Directory.Create();
            string rootPath = file.FullName;
            if (url == null)
                return;
            Uri uri = new Uri(url);
            string filename = "failed";

            if (uri != null)
            {
                filename = System.IO.Path.GetFileName(uri.LocalPath);
            }

            string fileName = System.IO.Path.Combine(rootPath, filename);
            image.Save(fileName);
        }

        private System.Drawing.Image DownloadImageFromUrl(string imageUrl)
        {
            System.Drawing.Image image = null;

            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                System.Net.WebResponse webResponse = webRequest.GetResponse();

                System.IO.Stream stream = webResponse.GetResponseStream();

                image = System.Drawing.Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return image;
        }


        
    }
}
