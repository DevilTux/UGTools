using System;
using System.Net;
using System.Text;

namespace UGTools.Utils
{
    public class RemoteFileHelper
    {
        #region -- Private members --

        private const int MaxSize = 65536; // max read buffer size conserves memory
        private const int MinSize = 8192; // min size prevents numerous small reads        

        #endregion

        #region -- Constructors --
        public static RemoteFileHelper Intance
        {
            get { return new RemoteFileHelper(); }
        }
        #endregion

        /// <summary>
        /// Hàm kiểm tra xem có request được ảnh hay không (Status code hợp lệ là 200 và 302)
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public bool CheckFileExists(string url)
        {
            try
            {
                var extRequest = (HttpWebRequest)WebRequest.Create(url);
                var extResponse = (HttpWebResponse)extRequest.GetResponse();
                return extResponse.StatusCode == HttpStatusCode.OK || extResponse.StatusCode == HttpStatusCode.Found;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy toàn bộ nội dung của URL vào một chuỗi string
        /// </summary>
        /// <param name="url">Đường dẫn tới trang cần lấy nội dung</param>
        /// <returns></returns>
        public string GetPageContent(string url)
        {
            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                var responseStream = httpResponse.GetResponseStream();

                if (responseStream != null)
                {
                    var length = (int)httpResponse.ContentLength;

                    // Use Content-Length if between bufSizeMax and bufSizeMin
                    var bufSize = MinSize;
                    if (length > bufSize)
                        bufSize = length > MaxSize ? MaxSize : length;

                    // Allocate buffer and StringBuilder for reading response
                    var buffer = new byte[bufSize];
                    var result = new StringBuilder(bufSize);

                    // Read response stream until end
                    while ((length = responseStream.Read(buffer, 0, buffer.Length)) != 0)
                        result.Append(Encoding.UTF8.GetString(buffer, 0, length));

                    return result.ToString();
                }
                return string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
