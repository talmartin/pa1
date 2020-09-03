using System;
using System.Globalization;

namespace pa1
{
    public class Posts : IComparable<Posts>
    {
        public int ID {get; set;}
        public string Text{get; set;}
        public DateTime Stamp{get; set;}

        public int CompareTo(Posts temp)
        {
            return this.Stamp.CompareTo(temp.Stamp);
        }

        public override string ToString()
        {
            return this.ID + ": " + this.Text + " / " + this.Stamp;
        }
    }
}