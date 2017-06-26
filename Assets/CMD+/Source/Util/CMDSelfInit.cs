#if UNITY_5

using UnityEngine;

namespace DaanRuiter.CMDPlus
{
    public static class CMDSelfInit
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void OnLoad()
        {
            CMD.Init();
        }
    }
}

#endif