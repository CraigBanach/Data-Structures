using System.Collections.Generic;

namespace DataStructSandBox.DataStructures
{         
    class BinaryTree<T>
    {
        private Node<T> _root;

        public BinaryTree()
        {
            this._root = null;
        }

        public void AddNode(T data) 
        {
            var newNode = new Node()
            {
                Data = data,
                LeftChild = null,
                RightChild = null
            };


            if(this._root == null) 
            {
                this._root = newNode;
            }
            else 
            {
                AddRecursive(this._root, newNode);
            }
        }

        private void AddRecursive(Node<T> currentRoot, Node<T> newNode)
        {
            if(currentRoot == null) 
            {
                currentRoot = newNode;
            }

            if(Compare(currentRoot.Data, newNode.Data) >= 0) 
            {
                if(currentRoot.LeftChild == null)
                {
                    currentRoot.LeftChild = newNode;
                }
                else 
                {
                    AddRecursive(currentRoot.LeftChild, newNode);
                }
            }
            else
            {
                if(currentRoot.RightChild == null)
                {
                    currentRoot.RightChild = newNode;
                }
                else 
                {
                    AddRecursive(currentRoot.RightChild, newNode);
                }
            }
        }

        public void AddNodes(IEnumerable<T> nodesToAdd) 
        {
            foreach (var node in nodesToAdd)
            {
                AddNode(node);
            }
        }

        public void Clear() 
        {
            this._root = null;
        }
    }

    class Node<T> {
        public T Data { get; set; }    
        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }
    }
}