using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FSMMachine<entity_type>
{
    entity_type m_owner;
    private FSMState<entity_type> m_currentState = null;
    private FSMState<entity_type> m_previousState = null;
    private FSMState<entity_type> m_globalState = null;

    public FSMMachine(entity_type entity)
    {
        m_owner = entity;
    }

    public void Update()
    {
        if (null != m_globalState)
        {
            m_globalState.onExecute(m_owner);
        }

        if (null != m_currentState)
        {
            m_currentState.onExecute(m_owner);
        }
    }

    /// <summary>
    /// 有状态变更时，才会触发 onEnter 事件
    /// </summary>
    /// <param name="newState"></param>
    public void ChangeState(FSMState<entity_type> newState)
    {
        if (null == newState)
        {
            Debug.LogError("new state is null");
            return;
        }

        m_previousState = m_currentState;
        if (null != m_currentState)
        {
            m_currentState.onExit(m_owner);
        }
        m_currentState = newState;
        m_currentState.onEnter(m_owner);
    }

    public void ResetToPreviousState()
    {
        ChangeState(m_previousState);
    }

    public FSMState<entity_type> CurState()
    {
        return m_currentState;
    }

}
