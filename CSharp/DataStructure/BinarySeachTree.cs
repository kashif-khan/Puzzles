using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure
{
    public class BinarySeachTree<T>
    {
        public T Value { get; }

        public BinarySeachTree<T> Left { get; set; }

        public BinarySeachTree<T> Right { get; set; }

        public BinarySeachTree(T value)
        {
            Value = value;
        }

        public static int Compare(T leftOperand, T rightOperrand)
        {
            if (leftOperand == null)
            {
                throw new ArgumentNullException(nameof(leftOperand));
            }
            if (rightOperrand == null)
            {
                throw new ArgumentNullException(nameof(rightOperrand));
            }
            return Comparer<T>.Default.Compare(leftOperand, rightOperrand);
        }


        public static BinarySeachTree<T> Insert(BinarySeachTree<T> parentNode, T value)
        {
            return Insert(parentNode, new BinarySeachTree<T>(value));
        }

        public static BinarySeachTree<T> Insert(BinarySeachTree<T> parentNode, BinarySeachTree<T> newNode)
        {
            if (parentNode == null)
            {
                return newNode;
            }

            if (Compare(newNode.Value, parentNode.Value) >= 0)
            {
                parentNode.Right = Insert(parentNode.Right, newNode);
            }
            else
            {
                parentNode.Left = Insert(parentNode.Left, newNode);
            }
            return parentNode;
        }

        public static void InOrderPrint(BinarySeachTree<T> parentNode)
        {
            if (parentNode == null)
            {
                return;
            }
            InOrderPrint(parentNode.Left);
            Console.WriteLine(parentNode.Value);
            InOrderPrint(parentNode.Right);
        }

        public static BinarySeachTree<T> Search(BinarySeachTree<T> parentNode, T searchOperand)
        {
            return Search(parentNode, new BinarySeachTree<T>(searchOperand));
        }

        public static BinarySeachTree<T> Search(BinarySeachTree<T> parentNode, BinarySeachTree<T> searchOperand)
        {
            if (parentNode == null)
            {
                return null;
            }
            if (parentNode == searchOperand)
            {
                return parentNode;
            }
            if (searchOperand >= parentNode)
            {
                return Search(parentNode.Right, searchOperand);
            }
            else
            {
                return Search(parentNode.Left, searchOperand);
            }
        }

        public static bool operator >=(BinarySeachTree<T> leftOperand, BinarySeachTree<T> rightOperand)
        {
            return Compare(leftOperand.Value, rightOperand.Value) >= 0;
        }

        public static bool operator <=(BinarySeachTree<T> leftOperand, BinarySeachTree<T> rightOperand)
        {
            return Compare(leftOperand.Value, rightOperand.Value) <= 0;
        }

        public static bool operator ==(BinarySeachTree<T> leftOperand, BinarySeachTree<T> rightOperand)
        {
            if (leftOperand is null && rightOperand is null)
            {
                return true;
            }
            if (leftOperand is null || rightOperand is null)
            {
                return false;
            }
            return Comparer<T>.Default.Compare(leftOperand.Value, rightOperand.Value) == 0;
        }

        public static bool operator !=(BinarySeachTree<T> leftOperand, BinarySeachTree<T> rightOperand)
        {
            return !(leftOperand == rightOperand);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            return this == obj as BinarySeachTree<T>;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                //TODO extract the constants to a separate file
                // Choose large primes to avoid hashing collisions
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, Value) ? Value.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
