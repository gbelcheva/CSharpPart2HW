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
    using System.Drawing;

    public class Vertex
    {
        public int ident {get; private set; }
        public int dist { get; set; }

        public Vertex(int ident)
        {
            this.ident = ident;
        }
    }
}
