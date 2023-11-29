using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class14
{
    internal class AdjacencyList
    {
        // 그래프의 사이즈
        int size;

        // 그래프의 인접 리스트
        private List<int>[] adjacencyList;

        public AdjacencyList(int vertexSize)
        {
            size = vertexSize;
            adjacencyList = new List<int>[vertexSize];

            for (int i = 0; i < vertexSize; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        public void InsertEdge(int vertex, int edge)
        {
            adjacencyList[vertex].Add(edge);
        }

        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < adjacencyList[i].Count; j++)
                {
                    Console.Write(adjacencyList[i][j] + "->");
                }

                Console.WriteLine(" "); // <-
            }
        }

        public void BSF(int root)
        {
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[size];
            queue.Enqueue(root);
            visited[root] = true;
            
            while(queue.Count>0)
            {
                int now = queue.Dequeue();
                Console.WriteLine(now);

                for(int next=0; next<size; next++)
                {
                    if (visited[next]== true)
                    {
                        continue;
                    }
                    queue.Enqueue(next);
                    visited[next] = true;
                }
            }


            

        }
        public void BFS1(int root)
        {
            // 방문한 노드를 추적하기 위한 배열
            bool[] visited = new bool[size];

            // Queue 컬렉션을 선언한다.
            Queue<int> q = new Queue<int>();

            // Queue에 root 노드를 넣어준다.
            q.Enqueue(root);

            // visited 방문 체크
            visited[root] = true;

            // 1. Queue가 비어있을 때 까지 반복한다.
            while(q.Count>0)
            {
                // 2. Queue에서 데이터를 뽑는다.
                int index = q.Dequeue();

                // 3. Queue에서 뽑은 데이터를 출력한다.
                Console.Write(index + " ");
                // 4. 반복문을 이용해서 자기와 인접한 노드를 Queue에 넣는다.
                for (int i=0; i < adjacencyList[index].Count; i++ )
                {
                    // 5. 방문하지 않은 정점이라고 한다면
                    if (visited[adjacencyList[index][i]] == false)
                    {
                        // 6. 해당 vertex 방문 체크해주고 Queue에 데이터를 넣어준다.
                        visited[adjacencyList[index][i]] = true;

                        q.Enqueue(adjacencyList[index][i]);
                    }
                }


            }
        }
        public void Visited(int vertex)
        {
            
        }
    }
}
