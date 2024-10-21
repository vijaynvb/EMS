namespace EMSApi.Utils
{
    public class DBLogs : ILogs {

        public DBLogs()
        {

        }
        public void WriteLog(string str)
        {
            // file log [connect to db, table]
            Console.WriteLine(str);
        }

    }
}
