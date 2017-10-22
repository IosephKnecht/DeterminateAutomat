using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp16.Data
{
    /// <summary>
    /// Псевдо-коллекция...
    /// </summary>
    public class LinkCollection
    {
        private List<object> list;

        public LinkCollection()
        {
            list = new List<object>();
        }

        public int Count
        {
            get { return list.Count; }
        }

        public Link this[int index]
        {
            get
            {
                try
                {
                    return (Link)list[index];
                }
                catch
                {
                    return null;
                }
            }
        }

        public void Add(Link link)
        {
            list.Add(link);
        }

        public void RemoveAt(int index)
        {
            try
            {
                list.RemoveAt(index);
            }
            catch
            { }
        }

        /// <summary>
        /// Метод осуществляющий поиск линков,началом которых является входной узел...
        /// </summary>
        /// <param name="start_node">Входной узел...</param>
        /// <returns>Массив линков...</returns>
        public LinkCollection SearchByStartNode(Node start_node)
        {
            LinkCollection links = new LinkCollection();

            foreach(Link link in list)
            {
                if (link.Start_node.Equals(start_node)) links.Add(link);
            }

            return links;
        }

        /// <summary>
        /// Осуществляет единичного поиск линка...
        /// </summary>
        /// <param name="start_node_name">Имя узла...</param>
        /// <param name="trans">Переход линка...</param>
        /// <returns>Линк с задынным именем и переходом...</returns>
        public Link SearchByStartNodeAndTrans(string start_node_name,string trans)
        {
            //string start_node_name = start_node.Name;

            foreach (Link link in list)
            {
                if (link.Start_node.Name == start_node_name && link.Trans == trans) return link;
            }

            return null;
        }

        /// <summary>
        /// Метод осуществляющий слияние двух линков с их последующим удалением...
        /// </summary>
        /// <param name="link1">Первый линк...</param>
        /// <param name="link2">Второй линк...</param>
        public void MergeLink(Link link1,Link link2)
        {
            string new_name = link1.Final_node.Name + link2.Final_node.Name;
            new_name = new string((new_name).Distinct().ToArray());
            new_name = new string(new_name.OrderBy(key => key).ToArray());
            bool new_sost = link1.Final_node.Sost | link2.Final_node.Sost;
            Node new_final_node = new Node(new_name, new_sost,true);
            Link new_link = new Link(link1.Start_node, new_final_node, link1.Trans);
            list.RemoveAt(list.IndexOf(link1));
            list.RemoveAt(list.IndexOf(link2));
            list.Add(new_link);
        }

        public bool Contains(Link other)
        {
            foreach (object l in list)
            {
                Link link = (Link)l;
                if (link.Equals(other)) return true;
            }

            return false;
        }

        public int IndexOf(Link other)
        {
            int count = 0;

            foreach (object l in list)
            {
                Link link = (Link)l;
                if (link.Equals(other)) return count;
                count++;
            }

            return -1;
        }


    }
}
