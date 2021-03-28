using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public interface ICollisionRepeater
{
    Action<Collision2D> OnCollisionEnter { get; set; }
    Action<Collision2D> OnCollisionExit { get; set; }
    Action<Collision2D> OnCollisionStay { get; set; }
}