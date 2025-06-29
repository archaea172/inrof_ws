using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ROS2
{
    public class button_ros2 : MonoBehaviour
    {
        private ROS2UnityComponent ros2Unity;
        private ROS2Node ros2Node;
        private IPublisher<std_msgs.msg.String> string_pub;

        // Start is called before the first frame update
        void Start()
        {
            ros2Unity = GetComponent<ROS2UnityComponent>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void on_click()
        {
            if (ros2Unity.Ok())
            {
                if (ros2Node == null)
                {
                    ros2Node = ros2Unity.CreateNode("unity_ros2_node");
                    string_pub = ros2Node.CreatePublisher<std_msgs.msg.String>("button");
                }
                std_msgs.msg.String txdata = new std_msgs.msg.String();
                txdata.Data = "hello world from button";
                string_pub.Publish(txdata);
            }
        }
    }
}