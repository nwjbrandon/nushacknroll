//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.NiryoOne
{
    [Serializable]
    public class OpenGripperResponse : Message
    {
        public const string k_RosMessageName = "niryo_one_msgs/OpenGripper";
        public override string RosMessageName => k_RosMessageName;

        public byte state;

        public OpenGripperResponse()
        {
            this.state = 0;
        }

        public OpenGripperResponse(byte state)
        {
            this.state = state;
        }

        public static OpenGripperResponse Deserialize(MessageDeserializer deserializer) => new OpenGripperResponse(deserializer);

        private OpenGripperResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.state);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.state);
        }

        public override string ToString()
        {
            return "OpenGripperResponse: " +
            "\nstate: " + state.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}