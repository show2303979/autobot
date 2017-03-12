using System;
using System.IO;
using EloBuddy.SDK;
using EloBuddy.SDK.Rendering;
using SharpDX;
using Line = EloBuddy.SDK.Rendering.Line;

namespace AutoBuddy.Utilities.Pathfinder
{
    internal class Node
    {
        public int[] Neighbors;
        public readonly Vector3 position;
        private readonly NavGraph navGraph;
        public bool passable = true;


        public Node(int[] neighbors, Vector3 pos, NavGraph graph)
        {
            navGraph = graph;
            position=pos;
            Neighbors = neighbors;
        }
        public Node(Stream f, byte[] b, NavGraph graph)
        {
            navGraph = graph;
            f.Read(b, 0, 4);
            Neighbors = new int[BitConverter.ToInt32(b, 0)];
            for (var i = 0; i < Neighbors.Length; i++)
            {
                f.Read(b, 0, 4);
                Neighbors[i] = BitConverter.ToInt32(b, 0);
            }
            position=new Vector3();
            f.Read(b, 0, 4);
            position.X = BitConverter.ToSingle(b, 0);
            f.Read(b, 0, 4);
            position.Y = BitConverter.ToSingle(b, 0);
            f.Read(b, 0, 4);
            position.Z = BitConverter.ToSingle(b, 0);


        }

        public void Serialize(FileStream f)
        {
            f.Write(BitConverter.GetBytes(Neighbors.Length), 0, 4);
            foreach (var neighbor in Neighbors)
            {
                f.Write(BitConverter.GetBytes(neighbor), 0, 4);
            }
            f.Write(BitConverter.GetBytes(position.X), 0, 4);
            f.Write(BitConverter.GetBytes(position.Y), 0, 4);
            f.Write(BitConverter.GetBytes(position.Z), 0, 4);
        }

        public float GetDistance(int dest)
        {
            return position.Distance(navGraph.Nodes[dest].position);
        }

        public void AddNeighbor(int neighbor)
        {
            var tmp = new int[Neighbors.Length + 1];
            Neighbors.CopyTo(tmp, 0);
            Neighbors = tmp;
            Neighbors[Neighbors.Length - 1] = neighbor;
        }
        public void RemoveNeighbor(int neighbor)
        {
            var tmp = new int[Neighbors.Length - 1];
            var index = 0;
            for (var i = 0; i < Neighbors.Length; i++)
            {
                if (Neighbors[i] != neighbor) continue;
                index = i;
                break;
            }
            Array.Copy(Neighbors, 0, tmp, 0, index);
            Array.Copy(Neighbors, index + 1, tmp, index, Neighbors.Length-index-1);
            Neighbors = tmp;
        }

        public void DrawPositions()
        {
            if (position.IsOnScreen())
            {
                Circle.Draw(navGraph.NodeColor, 40,2f,  position);
            }
        }
        public void DrawLinks()
        {
            var onscreen = position.IsOnScreen();
            foreach (var i in Neighbors)
            {
                var n = navGraph.Nodes[i];
                if (onscreen || n.position.IsOnScreen())
                    Line.DrawLine(navGraph.LineColor, 1f, position, n.position);
            }
        }
    }
}
