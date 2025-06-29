using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ROS2
{
    public class status_control : MonoBehaviour
    {
        private ROS2UnityComponent ros2Unity;
        private ROS2Node ros2Node;
        // Start is called before the first frame update
        void Start()
        {
            ros2Unity = GetComponent<ROS2UnityComponent>();
            if (ros2Unity.Ok())
            {
                if (ros2Node == null)
                {
                    ros2Node = ros2Unity.CreateNode("status_controler");
                }
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}