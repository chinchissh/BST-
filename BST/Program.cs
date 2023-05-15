using System;

namespace BST //Обычное бинанрное дерево поиска
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            // Узлы
            tree.Insert(10);
            tree.Insert(50);
            tree.Insert(80);
            tree.Insert(40);
            tree.Insert(90);
            tree.Insert(60);
            tree.Insert(70);

            // Содержимое дерева
            Console.Write("Попорядковый обход: ");
            tree.InOrder();
            Console.WriteLine();
        }
    }
}