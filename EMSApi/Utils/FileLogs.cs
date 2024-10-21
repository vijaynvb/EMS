namespace EMSApi.Utils
{
    public class FileLogs : ILogs
    {
        public FileLogs()
        {

        }
        public void WriteLog(string str)
        {
            // file log [create a file, open a file, write log and close the file]
            Console.WriteLine(str);
        }
    }
}
