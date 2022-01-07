//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.NiryoOne
{
    [Serializable]
    public class GetTargetPoseRequest : Message
    {
        public const string k_RosMessageName = "niryo_one_msgs/GetTargetPose";
        public override string RosMessageName => k_RosMessageName;

        public const string GRIP_AUTO = "auto";
        public string workspace;
        public string grip;
        public int tool_id;
        //  Used if grip_name = GRIP_AUTO
        public float height_offset;
        public float x_rel;
        public float y_rel;
        public float yaw_rel;

        public GetTargetPoseRequest()
        {
            this.workspace = "";
            this.grip = "";
            this.tool_id = 0;
            this.height_offset = 0.0f;
            this.x_rel = 0.0f;
            this.y_rel = 0.0f;
            this.yaw_rel = 0.0f;
        }

        public GetTargetPoseRequest(string workspace, string grip, int tool_id, float height_offset, float x_rel, float y_rel, float yaw_rel)
        {
            this.workspace = workspace;
            this.grip = grip;
            this.tool_id = tool_id;
            this.height_offset = height_offset;
            this.x_rel = x_rel;
            this.y_rel = y_rel;
            this.yaw_rel = yaw_rel;
        }

        public static GetTargetPoseRequest Deserialize(MessageDeserializer deserializer) => new GetTargetPoseRequest(deserializer);

        private GetTargetPoseRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.workspace);
            deserializer.Read(out this.grip);
            deserializer.Read(out this.tool_id);
            deserializer.Read(out this.height_offset);
            deserializer.Read(out this.x_rel);
            deserializer.Read(out this.y_rel);
            deserializer.Read(out this.yaw_rel);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.workspace);
            serializer.Write(this.grip);
            serializer.Write(this.tool_id);
            serializer.Write(this.height_offset);
            serializer.Write(this.x_rel);
            serializer.Write(this.y_rel);
            serializer.Write(this.yaw_rel);
        }

        public override string ToString()
        {
            return "GetTargetPoseRequest: " +
            "\nworkspace: " + workspace.ToString() +
            "\ngrip: " + grip.ToString() +
            "\ntool_id: " + tool_id.ToString() +
            "\nheight_offset: " + height_offset.ToString() +
            "\nx_rel: " + x_rel.ToString() +
            "\ny_rel: " + y_rel.ToString() +
            "\nyaw_rel: " + yaw_rel.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}