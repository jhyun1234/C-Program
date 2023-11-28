using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class AdjacencyList<T>
    {

        // 그래프의 인접 리스트
        private int size;
        private List<char>[] adjacencyList;
        private T[] vertxe;

        public AdjacencyList()
        {

        }

        public void AddEdge(int x, int y)
        {

        }

        public void Insertvertex(T data)
        {
            vertxe[size++]=data;
        }

    }
}
