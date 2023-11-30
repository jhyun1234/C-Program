using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Class14
{
    internal class AdjancencyMatrix<T>
    {
        // 속성
        // 1. 정점의 수 (size)
        // 2. 정점의 이름(vertex)
        // 3. 인접 행렬 (2차원 배열)

        private int size;
        private T[] vertex;
        private int[,] matrix;
        public AdjancencyMatrix(int matrixSize)
        {
            size = 0;
            vertex = new T[matrixSize];
            matrix = new int[matrixSize, matrixSize];



        }
        
          
        public void InsertEdge(int x ,int y)
        {
            matrix[x, y] = 1;
            matrix[y, x] = 1;
        }

        public void InsertVertex(T data)
        {
            vertex[size++] = data;
        }

        public void Display()
        {
            Console.WriteLine("Vertex Size : "+size);
            Console.WriteLine(" ");

            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    Console.Write(matrix[i,j]+ " ");
                }

                Console.WriteLine(" ");
            }
        }
    }

    
}
