using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure
{
    public class IntervalTree<T>
    {
        public T Low { get; }
        public T High { get; }
        public IntervalTree<T> Left { get; set; }
        public IntervalTree<T> Right { get; set; }
        public T MaxValue
        {
            get
            {
                if (Left == null && Right == null)
                {
                    return High;
                }
                if (Left != null && Right == null)
                {
                    return Left.High;
                }
                if (Left == null && Right != null)
                {
                    return Right.High;
                }
                return IntervalTree<T>.Max(High, IntervalTree<T>.Max(Left.MaxValue, Right.MaxValue));
            }
        }

        public static T Max(T leftOperand, T rightOperrand)
        {
            if (leftOperand == null)
            {
                throw new ArgumentNullException(nameof(leftOperand));
            }
            if (rightOperrand == null)
            {
                throw new ArgumentNullException(nameof(rightOperrand));
            }
            return Comparer<T>.Default.Compare(leftOperand, rightOperrand) > 0 ? leftOperand : rightOperrand;
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

        public IntervalTree(T low, T high)
        {
            Low = low;
            High = high;
        }

        public static IntervalTree<T> Insert(IntervalTree<T> parentNode, IntervalTree<T> interval)
        {
            if (parentNode == null)
            {
                return interval;
            }
            if (parentNode > interval)
            {
                parentNode.Left = Insert(parentNode.Left, interval);
            }
            else
            {
                parentNode.Right = Insert(parentNode.Right, interval);
            }
            return parentNode;
        }

        public static IntervalTree<T> Insert(IntervalTree<T> parentNode, T low, T high)
        {
            return Insert(parentNode, new IntervalTree<T>(low, high));
        }

        public static IntervalTree<T> Search(IntervalTree<T> parentNode, IntervalTree<T> interval)
        {
            if (parentNode == null)
            {
                return null;
            }
            if (DoOverlap(parentNode, interval))
            {
                return parentNode;
            }
            if (IntervalTree<T>.Compare(parentNode.Low, interval.High) >= 0)
            {
                return Search(parentNode.Left, interval);
            }
            else
            {
                return Search(parentNode.Right, interval);
            }
        }

        public static bool DoOverlap(IntervalTree<T> parentNode, IntervalTree<T> interval)
        {
            if (IntervalTree<T>.Compare(interval.High, parentNode.Low) >= 0 && IntervalTree<T>.Compare(parentNode.High, interval.Low) >= 0)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(IntervalTree<T> leftOperand, IntervalTree<T> rightOperand)
        {
            if (leftOperand is null)
            {
                throw new ArgumentNullException(nameof(leftOperand));
            }
            if (rightOperand is null)
            {
                throw new ArgumentNullException(nameof(rightOperand));
            }
            return IntervalTree<T>.Compare(leftOperand.Low, rightOperand.Low) > 0;
        }

        public static bool operator <(IntervalTree<T> leftOperand, IntervalTree<T> rightOperand)
        {
            return !(leftOperand < rightOperand);
        }

        public static bool operator >=(IntervalTree<T> leftOperand, IntervalTree<T> rightOperand)
        {
            if (leftOperand is null)
            {
                throw new ArgumentNullException(nameof(leftOperand));
            }
            if (rightOperand is null)
            {
                throw new ArgumentNullException(nameof(rightOperand));
            }
            return IntervalTree<T>.Compare(leftOperand.Low, rightOperand.Low) >= 0;
        }

        public static bool operator <=(IntervalTree<T> leftOperand, IntervalTree<T> rightOperand)
        {
            if (leftOperand is null)
            {
                throw new ArgumentNullException(nameof(leftOperand));
            }
            if (rightOperand is null)
            {
                throw new ArgumentNullException(nameof(rightOperand));
            }
            return IntervalTree<T>.Compare(leftOperand.Low, rightOperand.Low) <= 0;
        }

        public static bool operator ==(IntervalTree<T> leftOperand, IntervalTree<T> rightOperand)
        {
            if (leftOperand is null && rightOperand is null)
            {
                return true;
            }
            if (leftOperand is null || rightOperand is null)
            {
                return false;
            }
            return (IntervalTree<T>.Compare(leftOperand.Low, rightOperand.Low) == 0 && IntervalTree<T>.Compare(leftOperand.High, rightOperand.High) == 0);
        }

        public static bool operator !=(IntervalTree<T> leftOperand, IntervalTree<T> righOperand)
        {
            return !(leftOperand == righOperand);
        }

        public static bool Equals(IntervalTree<T> leftOperand, IntervalTree<T> righOperand)
        {
            return leftOperand == righOperand;
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

            return this == obj as IntervalTree<T>;
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
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, Low) ? Low.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, High) ? High.GetHashCode() : 0);
                return hash;
            }
        }

        public override string ToString()
        {
            return $"[{nameof(Low)}, {nameof(High)}, {nameof(MaxValue)}] : [ {Low}, {High}, {MaxValue}]";
        }
    }
}
