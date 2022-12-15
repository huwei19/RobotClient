using System;
using System.Collections;
using System.Collections.Generic;

///使用单例模式的协程管理器，用于驱动所有协程MoveNext
public class CoroutineManager
{
    private static CoroutineManager _instance = null;

    public static CoroutineManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new CoroutineManager();

            return _instance;
        }
    }

    ///链表存储所有协程对象
    private LinkedList<Coroutine> coroutineList = new LinkedList<Coroutine>();

    private LinkedList<Coroutine> coroutinesToStop = new LinkedList<Coroutine>();

    ///开启一个协程
    public Coroutine Start(IEnumerator ie)
    {
        var c = new Coroutine(ie);
        coroutineList.AddLast(c);
        return c;
    }

    ///关闭一个协程
    public void Stop(IEnumerator ie)
    {

    }

    public void Stop(Coroutine coroutine)
    {
        coroutinesToStop.AddLast(coroutine);
    }

    ///主线程驱动所有协程对象
    public void UpdateCoroutine()
    {
        var node = coroutineList.First;
        while (node != null)
        {
            var cor = node.Value;

            bool ret = false;
            if (cor != null)
            {
                bool toStop = coroutinesToStop.Contains(cor);
                if (!toStop)
                {
                    //一旦协程对象返回false，即意味着该协程要退出
                    ret = cor.MoveNext();
                }
            }

            if (!ret)
            {
                coroutineList.Remove(node);
                Console.WriteLine("[CoroutineManager] remove cor");
            }

            node = node.Next;
        }
    }

    //----------- 使用示例 ------ CoroutineManager.Instance.Start(CoroutineTest()); //
    public static IEnumerator CoroutineTest()
    {
        Console.WriteLine("[CoroutineTest] enter coroutine. begin return waitforseconds:0.5f");
        yield return new WaitForSeconds(0.5f);

        Console.WriteLine("[CoroutineTest] wait for seconds <0.5f> over. begin wait for frame:3");
        yield return new WaitForFrame(3);

        Console.WriteLine("[CoroutineTest] wait for frame <3> over. now exit corutine");
    }
    //----------- 使用示例 ------ //
}
