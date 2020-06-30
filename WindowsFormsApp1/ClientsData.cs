using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ClientsData
    {
        static Client Cur;
        static int CurPosition;
        static FileStream FileStream;
        static BinaryReader BinaryReader;
        static BinaryWriter BinaryWriter;
        private ClientsData()
        {
        }
        public static string OpenStreams()
        {
            try
            {
                FileStream = new FileStream("Data.txt", FileMode.Open, FileAccess.ReadWrite);
                BinaryReader = new BinaryReader(FileStream);
                BinaryWriter = new BinaryWriter(FileStream);
                return "Opened";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static void AddUser(Client User)
        {
            int Position = 100 * HashFunction(User.EmailI.ToLower());
            FileStream.Seek(Position, SeekOrigin.Begin);
            while (BinaryReader.PeekChar() == 'T')
            {
                FileStream.Seek(100, SeekOrigin.Current);
            }
            BinaryWriter.Write('T');
            BinaryWriter.Write(User.EmailI);
            BinaryWriter.Write(User.Pass);
            BinaryWriter.Write(User.Firstname);
            BinaryWriter.Write(User.Lastname);
            BinaryWriter.Write(User.Countried);
            BinaryWriter.Write(User.Aged);
            BinaryWriter.Write(User.Visa);
            BinaryWriter.Write(User.Phone);
            BinaryWriter.Flush();
        }
        public static bool IsRegistered(string Email)
        {
            int Position = 100 * HashFunction(Email);
            FileStream.Seek(Position, SeekOrigin.Begin);
            while (BinaryReader.PeekChar() == 'T')
            {
                BinaryReader.ReadChar();
                if (BinaryReader.ReadString().ToLower() == Email)
                {
                    return false;
                }
                Position += 100;
                FileStream.Seek(Position, SeekOrigin.Begin);
            }
            return true;
        }
        public static bool LogInChecker(string Email, string Pass)
        {
            int Position = 100 * HashFunction(Email);
            FileStream.Seek(Position, SeekOrigin.Begin);
            while (BinaryReader.PeekChar() == 'T')
            {
                int Temp = Position;
                BinaryReader.ReadChar();
                if (BinaryReader.ReadString().ToLower() == Email && BinaryReader.ReadString() == Pass)
                {
                    try
                    {
                        Cur = new Client(Email, Pass, BinaryReader.ReadString(), BinaryReader.ReadString(), BinaryReader.ReadString(),
                                     BinaryReader.ReadString(), BinaryReader.ReadString(), BinaryReader.ReadString(), BinaryReader.ReadInt32());
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                    
                    CurPosition = Position;
                    ClientsLogs.SetAdress(Temp);
                    return true;
                }
                Position += 100;
                FileStream.Seek(Position, SeekOrigin.Begin);
            }
            return false;
        }
        private static int HashFunction(string Key)
        {
            long Postion = 0;
            long Power = 1;
            for (int i = 0; i < Key.Length; ++i)
            {
                Postion += Key[i] * Power;
                Power *= 2;
            }
            Postion %= 997;
            return (int)Postion;
        }
        public static void UpdateAccount()
        {
            BinaryWriter.Seek(-4, SeekOrigin.Current);
            BinaryWriter.Write(Cur.AmountI);
            BinaryWriter.Flush();
        }
        public static void DeleteAccount()
        {
            BinaryWriter.Seek(CurPosition, SeekOrigin.Begin);
            BinaryWriter.Write('F');
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
        public static Client Current { get { return Cur; } }

    }
}
