using System.Collections;
using UnityEngine;
using TDZS.Infrastructure.Services;

namespace TDZS.Utility
{
    public interface ICoroutineRunner : IService
    {
        Coroutine StartCoroutine(IEnumerator routine);
    }
}
