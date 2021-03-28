using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class TriggerRepeater : MonoBehaviour, ITriggerRepeater
{
    Action<Collider2D> ITriggerRepeater.OnTriggerEnter { get; set; }
    Action<Collider2D> ITriggerRepeater.OnTriggerExit { get; set; }
    Action<Collider2D> ITriggerRepeater.OnTriggerStay { get; set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ((ITriggerRepeater)this).OnTriggerEnter?.Invoke(collision);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        ((ITriggerRepeater)this).OnTriggerStay?.Invoke(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ((ITriggerRepeater)this).OnTriggerExit?.Invoke(collision);
    }
}