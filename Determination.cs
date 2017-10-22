using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApp16.Data;

namespace WindowsFormsApp16
{
    class Determination
    {
        LinkCollection links;
        bool work;
        List<string> transitions = new List<string>();

        public Determination(LinkCollection links)
        {
            this.links = links;

            if (FirstMerge())
            {
                work = true;
                ConstructTransitions();
            }
        }

        /// <summary>
        /// Впомогательный метод,по определению количества переходов...
        /// </summary>
        private void ConstructTransitions()
        {
            for (int i = 0; i < links.Count; i++)
            {
                if (!transitions.Contains(links[i].Trans)) transitions.Add(links[i].Trans);
            }
        }

        /// <summary>
        /// Метод детерминирующий автомат...
        /// </summary>
        /// <param name="Parent_Node">Начальный узел...</param>
        public LinkCollection MergeLinks(Node Parent_Node)
        {
            if(work)
            {
                for (int i = 0; i < links.Count; i++)
                {
                    if (links[i].Final_node.Composite)
                    {
                        if(CreateNewLink(links[i].Final_node)) i = 0;
                    }
                }
            }
            return DeleteNanNodes(Parent_Node);
        }

        /// <summary>
        /// Вспомогательный метод для удаления недостижимых узлов...
        /// </summary>
        /// <param name="Parent_Node">Начальный узел...</param>
        private LinkCollection DeleteNanNodes(Node Parent_Node)
        {
            LinkCollection actual_links = links.SearchByStartNode(Parent_Node);
            for (int i = 0; i < actual_links.Count; i++)
            {
                var trans_links = links.SearchByStartNode(actual_links[i].Final_node);

                for(int j = 0; j < trans_links.Count; j++)
                {
                    if (!actual_links.Contains(trans_links[j])) actual_links.Add(trans_links[j]);
                }
            }

            return actual_links;
        }

        /// <summary>
        /// Метод реализующий логику добавления новых линков...
        /// </summary>
        /// <param name="final_node">Конечный узел линка с параметром Composite==true...</param>
        /// <returns>True-удалось добавить новый линк,False-линк оказался не уникальным...</returns>
        private bool CreateNewLink(Node final_node)
        {
            string final_node_name = final_node.Name;

            foreach(string s in transitions)
            {
                List<Link> trans_link = new List<Link>();

                foreach(char c in final_node_name)
                {
                    trans_link.Add(links.SearchByStartNodeAndTrans(c.ToString(),s));
                }

                if (AddNewLink(trans_link, final_node, s)) return true;
            }
            return false;
        }

        /// <summary>
        /// Вспомогательный метод для объединения всех линков по переходу...
        /// </summary>
        /// <param name="trans_link">Массив линков</param>
        /// <param name="final_node"></param>
        /// <param name="trans">Переход...</param>
        /// <returns>True-удалось добавить новый линк,False-линк оказался не уникальным...</returns>
        private bool AddNewLink(List<Link> trans_link,Node final_node,string trans)
        {
            string new_node_name = null;
            bool new_sost = false;

            foreach (Link link in trans_link)
            {
                if (link != null)
                {
                    new_node_name += link.Final_node.Name;
                    new_sost |= link.Final_node.Sost;
                }
            }

            if (new_node_name != null)
            {
                new_node_name = new string((new_node_name).Distinct().ToArray());
                new_node_name = new string(new_node_name.OrderBy(key => key).ToArray());
                Node new_final_node = new Node(new_node_name, new_sost, true);
                Link new_link = new Link(final_node, new_final_node, trans);
                if (!links.Contains(new_link))
                {
                    links.Add(new_link);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Метод осуществляющий первичное слияние узлов...
        /// </summary>
        /// <returns>True-если автомат недетерминирован,False-если автомат детерминирован...</returns>
        private bool FirstMerge()
        {
            bool NanDet = false;
            for (int i = 0; i < links.Count-1; i++)
            {
                if (links[i].MergeEquals(links[i + 1]))
                {
                    links.MergeLink(links[i], links[i + 1]);
                    i = 0;
                    NanDet = true;
                }
            }

            return NanDet;
        }
    }
}
