using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ThreadManager : MonoBehaviour
{
    public Button StartButton;

    public int ThreadNumber;

    public int TotalCount = 100;

    private object LockObj = new object();

    [HideInInspector]
    public ObjectPool<int> NumberPool = new ObjectPool<int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < TotalCount; i++)
        {
            NumberPool.Push(i + 1);
        }

        StartButton.onClick.AddListener(()=> {
            ThreadStart();
        });        
    }

    private void ThreadStart()
    {
        for (int i = 0; i < ThreadNumber; i++)
        {
            Work wk = new Work(i+1, this);
            Task t = Task.Factory.StartNew(() => {
                wk.Run();
            });
            //t.Wait();
        }
    }

    public void WriteConsole(int tNum, int number)
    {
        Debug.Log($"Thread Number:{tNum} CurrentNumber:{number}");
    }
}
