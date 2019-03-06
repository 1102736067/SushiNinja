using UnityEngine;
using System.Collections.Generic;

namespace PathologicalGames
{
    public static class PoolManager
    {
        /// <summary>
        /// �ض����ֵ䣨��һ���ֵ�(sting��spawnpool)������ض���
        /// ��ʼ��ֻ�ܷ���start��
        /// </summary>
        public static readonly ObjectPoolsDict Pools = new ObjectPoolsDict();
    }


    public static class PoolManagerUtils
    {
        internal static void SetActive(GameObject obj, bool state)
        {
#if (UNITY_3_5 || UNITY_3_4 || UNITY_3_3 || UNITY_3_2 || UNITY_3_1 || UNITY_3_0)
            obj.SetActiveRecursively(state);
#else
        obj.SetActive(state);
#endif
        }

        internal static bool activeInHierarchy(GameObject obj)
        {
#if (UNITY_3_5 || UNITY_3_4 || UNITY_3_3 || UNITY_3_2 || UNITY_3_1 || UNITY_3_0)
            return obj.active;
#else
        return obj.activeInHierarchy;
#endif

        }
    }



}