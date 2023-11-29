using System.Collections;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml;
using System.Xml.Linq;

namespace Program
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region 그래프

            // 정점(vertex)과 간선(Edge)들이 서로 복잡하게 연결되어 있는 자료구조이다.

            // 정점(vertex)
            // 노드(node)라고도 하며, 데이터가 저장되는 그래프의 기본 원소이다.

            // 간선(Edge)
            // 링크(link)라고도 하며, 정점 간의 관계를 나타낸다.

            // 인접 정점(adjacent vertex)
            // 하나의 정점에서 간선에 의해 직접 연결되어 있는 정점을 의미한다.

            // 차수 (Degree)
            // 정점에 연결되어 있는 간선의 수를 의미한다.

            // 진입 차수
            // 외부에서 오는 간선의 수를 의미

            // 진출 차수
            // 외부로 향하는 간선의 수를 의미

            // 단순 경로(Simple path)
            // 경로 중에서 반복되는 간선이 없는 경로를 의미한다.

            // 사이클(Cycle)
            // 시작 정점과 종료 정점이 같은 단순 경로를 의미한다.
            //
            #endregion

            #region 인접 행렬
            // 그래프에서 어느 노드들이 간선으로 연결되어 있는지를 나타내는 행렬이며,
            // 2차열 배열로 구현되어 있고 노드 사이에 간선이 있다면 1, 없다면 0으로 표현한다.
            /*
            AdjancencyMatrix<char> adjancency = new AdjancencyMatrix<char>(4);

            

            adjancency.InsertVertex('A');
            adjancency.InsertVertex('B');
            adjancency.InsertVertex('C');
            adjancency.InsertVertex('D');

            adjancency.InsertEdge(0, 1);
            adjancency.InsertEdge(0, 2);
            adjancency.InsertEdge(0, 3);
            adjancency.InsertEdge(1, 2);
            adjancency.InsertEdge(2, 3);

            adjancency.Display();
            */
            #endregion

            #region 인접 리스트
            /*
            // 각 노드에 연결된 노드들을 원소로 갖는 리스트들의 배열을 의미하며,
            // 인접 리스트가 있다면 [i]는 i 번째 노드에 연결된 노드들을 원소로
            // 가지는 리스트이다.

            AdjacencyList adjacencyList = new AdjacencyList(6);

            adjacencyList.InsertEdge(0, 1);
            adjacencyList.InsertEdge(0, 2);
            adjacencyList.InsertEdge(1, 3);
            adjacencyList.InsertEdge(1, 4);
            adjacencyList.InsertEdge(2, 5);
            adjacencyList.InsertEdge(2, 6);

            adjacencyList.Display();
            */
            #endregion

        }
    }
}