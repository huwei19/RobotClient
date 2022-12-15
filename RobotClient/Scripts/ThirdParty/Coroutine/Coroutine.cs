using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///协程类定义
public class Coroutine
{
    private IEnumerator _routine;
    public Coroutine(IEnumerator routine)
    {
        _routine = routine;
    }

    public bool MoveNext()
    {
        if (_routine == null)
            return false;

        //看迭代器当前的流程控制（即yield return 后边的对象）
        //是否是我们当前IWait对象，如果是，看是否满足moveNext的条件
        IWait wait = _routine.Current as IWait;
        bool moveNext = true;
        if (wait != null)
            moveNext = wait.Tick();

        if (!moveNext)
        {
            //此处有些不好理解。当时间没有到时，我们应该返回true
            //告诉管理器我们后边还有对象需要下一次继续迭代
            Console.WriteLine("[Coroutine] not movenext");
            return true;
        }
        else
        {
            //此时所有等待时间或者帧都已经迭代完毕，看IEnumerator对象后续是否还有yield return对象
            //将此结果通知给管理器，管理器会在下一次迭代时决定是否继续迭代该Coroutine对象
            Console.WriteLine("[Coroutine] movenext");
            return _routine.MoveNext();
        }
    }

    public void Stop()
    {
        _routine = null;
    }
}


//---------- 拓展管理 --------------//
public class ParamTime
{
    //deltaTime deltaMilTime 这俩值如果修改的话就俩个一起改，俩实际代表同一个时间间隔
    public const float deltaTime = 0.1f; //100毫秒执行一次 Update
    public const int deltaMilTime = 100; //100毫秒执行一次 Update
}

public interface IWait
{
    bool Tick();
}

public class WaitForSeconds : IWait
{
    public float waitTime = 0;

    public WaitForSeconds(float time)
    {
        waitTime = time;
    }

    bool IWait.Tick()
    {
        waitTime -= ParamTime.deltaTime;
        Console.WriteLine("[WaitForSeconds] now left:" + waitTime);
        return waitTime <= 0;
    }
}

public class WaitForFrame : IWait
{
    public int waitFrame = 0;

    public WaitForFrame(int frame)
    {
        waitFrame = frame;
    }

    bool IWait.Tick()
    {
        waitFrame--;
        Console.WriteLine("[WaitForFrame] now left:" + waitFrame);
        return waitFrame <= 0;
    }
}
//---------- 拓展管理 --------------//