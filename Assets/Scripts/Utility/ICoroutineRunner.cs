using System.Collections;
using UnityEngine;

namespace TDZS.Utility
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator routine);
    }
}
