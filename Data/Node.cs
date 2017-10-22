using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp16.Data
{
    public class Node:IEquatable<Node>
    {
        string name;
        bool sost;
        /// <summary>
        /// Переменная определяющая является ли
        /// узел составным(по умолчанию False)...
        /// </summary>
        bool composite;

        public Node(string Name,bool sost=false,bool composite=false)
        {
            this.name = Name;
            this.sost = sost;
            this.composite = composite;
        }

        public string Name
        {
            get { return name; }
        }

        public bool Sost
        {
            get
            {
                return sost;
            }
        }

        public bool Composite
        {
            get { return composite; }
        }

        public bool Equals(Node other)
        {
            return this.name == other.Name &&
                   this.sost == other.sost;
        }
    }
}
