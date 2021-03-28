using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class CollisionRepeater : MonoBehaviour, ICollisionRepeater
{
    Action<Collision2D> ICollisionRepeater.OnCollisionEnter { get; set; }
    Action<Collision2D> ICollisionRepeater.OnCollisionExit { get; set; }
    Action<Collision2D> ICollisionRepeater.OnCollisionStay { get; set; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ((ICollisionRepeater)this).OnCollisionEnter?.Invoke(collision);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        ((ICollisionRepeater)this).OnCollisionExit?.Invoke(collision);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        ((ICollisionRepeater)this).OnCollisionStay?.Invoke(collision);
    }
}