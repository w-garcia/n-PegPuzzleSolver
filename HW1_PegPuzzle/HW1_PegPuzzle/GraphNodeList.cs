﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW1_PegPuzzle
{
    public class GraphNodeList<T> : CollectionBase
    {
            public GraphNodeList() : base() { }

            public GraphNodeList(int initialSize)
            {
                for (int i = 0; i < initialSize; i++)
                {
                    this.List.Add(default(GraphNode<T>));
                }
            }
            
            public void Add(GraphNode<T> node)
            {
                this.List.Add(node);
            }

            public GraphNode<T> FindByValue(T value)
            {
                // search the list for the value
                foreach (GraphNode<T> node in List)
                    if (node.Value.Equals(value))
                        return node;

                // if we reached here, we didn't find a matching node
                return null;
            }

            public GraphNode<T> Root()
            {
                if (this.List.Count > 0) return (GraphNode<T>)this.List[0];
                else return null;
            }

            public int IndexOf(GraphNode<T> node)
            {
                return this.List.IndexOf(node);
            }

            public GraphNode<T> ElementAt(int i)
            {
                if (this.List.Count > i) return (GraphNode<T>)this.List[i];
                else return null; 
            }

            public void Remove(GraphNode<T> node)
            {
                this.List.Remove(node);
            }
    }
}
