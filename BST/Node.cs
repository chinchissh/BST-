using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class Node
    {
        public int data; // Значение данных узла
        public Node left, right; // Ссылка на левое поддерево

        public Node(int item)
        {
            data = item; // Присваивание значения данных узла
            left = right = null; // Инициализация ссылок на поддеревья (левое и правое) как null
        }
    }

    public class BinaryTree
    {
        public Node root; // Корень дерева

        public BinaryTree() // Конструктор класса BinaryTree

        {
            root = null; // Инициализация корня дерева как null
        }

        public void Insert(int key) // Вставка элемента в дерево
        {
            root = Insert(root, key); // Вызов вспомогательного метода Insert для вставки элемента
        }

        Node Insert(Node root, int key) // Вспомогательный метод для вставки элемента
        {
            if (root == null) // Если текущий узел пустой, создаем новый узел с заданным ключом и делаем его корнем
            {
                root = new Node(key);
                return root;
            }

            if (key < root.data) // Если ключ меньше значения текущего узла, рекурсивно вставляем его в левое поддерево
            {
                root.left = Insert(root.left, key);
            }
            else if (key > root.data) // Если ключ больше значения текущего узла, рекурсивно вставляем его в правое поддерево
            {
                root.right = Insert(root.right, key);
            }

            return root; // Возвращаем корень поддерева после вставки
        }

        public void InOrder() // Обход дерева в порядке "in-order"
        {
            InOrder(root); // Вызов вспомогательного метода InOrder для обхода дерева
        }

        void InOrder(Node root) // Вспомогательный метод для обхода дерева в порядке "in-order"
        {
            if (root != null) // Если текущий узел не пустой
            {
                InOrder(root.left); // Рекурсивно обходим левое поддерево
                Console.Write(root.data + " "); // Выводим значение текущего узла на экран
                InOrder(root.right); // Рекурсивно обходим правое поддерево
            }
        }
    }
}