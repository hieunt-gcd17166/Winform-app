using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ClientsLogs
    {
        static FileStream FileStream;
        static BinaryReader BinaryReader;
        static BinaryWriter BinaryWriter;
        public static string OpenStreams()
        {
            try
            {
                FileStream = new FileStream("Logs.txt", FileMode.Open, FileAccess.ReadWrite);
                BinaryReader = new BinaryReader(FileStream);
                BinaryWriter = new BinaryWriter(FileStream);
                return "Opened";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static void SetAdress(int Address)
        {
            FileStream.Seek(2 * Address, SeekOrigin.Begin);
        }
        public static void GetLogs(DataGridView dg)
        {
            while (BinaryReader.PeekChar() == '|')
            {
                BinaryReader.ReadChar();
                dg.Rows.Add(BinaryReader.ReadString(), BinaryReader.ReadString());
            }
        }
        public static void AddLog(string s1, string s2)
        {
            BinaryWriter.Write('|');
            BinaryWriter.Write(s1);
            BinaryWriter.Write(s2);
            BinaryWriter.Flush();
        }
        public static bool CloseStreams()
        {
            try
            {
                BinaryReader.Close();
                BinaryWriter.Close();
                FileStream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
