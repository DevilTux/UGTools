using System;

namespace UGTools.Entity
{
    public class Socks5
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }

        #region -- Public method --

        public virtual void Load(string sock)
        {
            var part = sock.Split(':');
            IpAddress = part[0];
            Port = Convert.ToInt32(part[1]);
        }

        #endregion
    }
}
