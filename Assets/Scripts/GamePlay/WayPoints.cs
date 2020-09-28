using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class WayPoints : MonoBehaviour
    {
        public List<Vector3> GetWayPoints(int target)
        {
            List<Vector3> wayPoints = new List<Vector3>();
            int childCount = transform.childCount;

            if (!(target < childCount))
            {
                return wayPoints;
            }

            Transform temp = transform.GetChild(target);
            int tempChildCount = temp.childCount;

            for (int index = 0; index < tempChildCount; index++)
            {
                Vector3 waypointPostion = temp.GetChild(index).transform.position;
                wayPoints.Add(waypointPostion);
            }

            return wayPoints;
        }
    }
}