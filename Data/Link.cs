using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp16.Data
{
    public class Link:IEquatable<Link>
    {
        private Node start_node;
        private Node final_node;
        private string trans;
        public List<Link> last { get; set; }

        public Link(Node start,Node fin,string trans)
        {
            this.last = new List<Link>();
            this.start_node = start;
            this.final_node = fin;
            this.trans = trans;
        }

        public Node Start_node
        {
            get { return start_node; }
        }

        public Node Final_node
        {
            get { return final_node; }
        }

        public string Trans
        {
            get { return trans; }
        }

        public bool Equals(Link other)
        {
            return this.start_node.Equals(other.start_node) &&
                   this.final_node.Equals(other.final_node) &&
                   this.trans == other.trans;
        }

        /// <summary>
        /// Вспомогательный метод,определяющий сходство линков для слияния...
        /// </summary>
        /// <param name="other">Проверяемый линк...</param>
        /// <returns>True-линки могут быть слиты,False-линки нельзя слить...</returns>
        public bool MergeEquals(Link other)
        {
            return this.start_node.Equals(other.start_node) &&
                   this.trans == other.trans;
        }

        public override string ToString()
        {
            return start_node.Name + " ("+trans+")-> " + final_node.Name;
        }
    }
}
