using System.Collections;
using System;
public enum StateID
{
    STATE_NONE = -1,
}

public class FSMState<entity_type>
{
    private DateTime m_timeLast = new DateTime(); //单位秒
    private int m_interval = 0; //单位毫秒

    /// <summary>
    /// login接口完成后，
    /// 真正开始进入 各个业务的接口 (只会执行一次) （相当于start）
    /// </summary>
    /// <param name="entity"></param>
    public virtual void onEnter(entity_type entity) { }

    public virtual void onExit(entity_type entity) { }
    
    /// <summary>
    /// 一直update执行，直到 onExit
    /// </summary>
    /// <param name="entity"></param>
    public virtual void onExecute(entity_type entity) {}

    public virtual string getName() { return "Unknown"; }

    public virtual Robot.RobotType getTypeStat() { return Robot.RobotType.TYPE_NONE; }

    public void setInterval(int ainterval)
    {
        m_interval = ainterval;
    }
    public int getInterval()
    {
        return m_interval;
    }

    public bool isRun()
    {
        TimeSpan span = new TimeSpan(DateTime.Now.Ticks - m_timeLast.Ticks);
        if (span.TotalMilliseconds >= m_interval) {
            m_timeLast = DateTime.Now;
            return true;
        }
        return false;
    }
}
