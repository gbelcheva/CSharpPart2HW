/*
 * Author: Jeppe Andersen
 * Website: nocture.dk
 * 
 * Feel free to use this in any way you want :-)
 * 
 */
namespace PeshosFriends
{
    using System;

    public class Edge
    {
        public int from { get; private set; }
        public int to { get; private set; }
        public Double weight { get; private set; }

        public Edge(int from, int to, Double weight)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }
    }
}
