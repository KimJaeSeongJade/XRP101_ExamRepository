using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PooledBehaviour : MonoBehaviour
{
    public Stack<PooledBehaviour> Pool { get; set; }

    public virtual void ReturnPool()
    {
        Pool.Push(this);
        gameObject.SetActive(false);
    }

    public virtual void OnTaken<T>(T t)
    {
    }

    public virtual void OnTaken()
    {
    }
}
