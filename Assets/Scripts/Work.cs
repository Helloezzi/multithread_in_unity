using System.IO;

public class Work
{
    int tNum;

    private ThreadManager ThreadManager;

    public Work(int _tNum, ThreadManager manager)
    {
        tNum = _tNum;
        ThreadManager = manager;
    }

    public void Run()
    {
        while(ThreadManager.NumberPool.Count > 0)
        {
            int n = ThreadManager.NumberPool.Pop();
            ThreadManager.WriteConsole(tNum, n);
        }
    }    
}