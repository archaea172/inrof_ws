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
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void on_click()
        {
            ros2Unity = GetComponent<ROS2UnityComponent>();
            if (ros2Unity.Ok())
            {
                if (ros2Node == null)
                {
                    ros2Node = ros2Unity.CreateNode("ROS2UnityTalkerNode");
                    string_pub = ros2Node.CreatePublisher<std_msgs.msg.String>("chatter");
                }

                std_msgs.msg.String msg = new std_msgs.msg.String();
                msg.Data = "hellow world from button";
                string_pub.Publish(msg);
            }
        }
    }
}