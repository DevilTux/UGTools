using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace UGTools.DataAccess
{
    public class IniFile
    {
        private string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
          string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
          string key, string def, StringBuilder retVal,
          int size, string filePath);

        public IniFile(string iniPath)
        {
            path = iniPath;
        }

        public void IniWriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, path);
        }

        public string IniReadValue(string section, string key)
        {
            var temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", temp, 255, path);
            return temp.ToString();
        }
        public int IniReadIntValue(string section, string key)
        {
            var temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", temp, 255, path);
            return Convert.ToInt32(temp.ToString());
        }
    }
    //class IniFile
    //{
    //    public string Path;
    //    static string EXE = Assembly.GetExecutingAssembly().GetName().Name;

    //    [DllImport("kernel32")]
    //    static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

    //    [DllImport("kernel32")]
    //    static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

    //    public IniFile(string IniPath = null)
    //    {
    //        Path = new FileInfo(IniPath != null ? IniPath : EXE + ".ini").FullName.ToString();
    //    }

    //    public string Read(string Key, string Section = null)
    //    {
    //        StringBuilder RetVal = new StringBuilder(255);
    //        GetPrivateProfileString(Section != null ? Section : EXE, Key, "", RetVal, 255, Path);
    //        return RetVal.ToString();
    //    }

    //    public void Write(string Key, string Value, string Section = null)
    //    {
    //        WritePrivateProfileString(Section != null ? Section : EXE, Key, Value, Path);
    //    }

    //    public void DeleteKey(string Key, string Section = null)
    //    {
    //        Write(Key, null, Section != null ? Section : EXE);
    //    }

    //    public void DeleteSection(string Section = null)
    //    {
    //        Write(null, null, Section != null ? Section : EXE);
    //    }

    //    public bool KeyExists(string Key, string Section = null)
    //    {
    //        return Read(Key, Section).Length > 0 ? true : false;
    //    }
    //}
}
