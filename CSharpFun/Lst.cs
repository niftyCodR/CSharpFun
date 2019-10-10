using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFun
{
    /// <summary>
    /// Represents a readonly list of items. Items cannot be null.
    /// </summary>
    public struct Lst<T> : IReadOnlyList<T>, IEquatable<Lst<T>>, IList<T>
    {
        private readonly IList<T> _items;

        /// <summary>
        /// Initializes a new instance of the <see cref="Lst{T}"/> type.
        /// </summary>
        /// <param name="items">
        /// The collection of items in the list.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Thrown when an item in the provided collection is null.
        /// </exception>
        public Lst(params T[] items)
        {
            _items = items?.ToArray();

            if(NonEmptyItems.Any(item => item == null))
                throw new ArgumentException("Items cannot be null.", nameof(items));
        }

        public bool IsEmpty => Count == 0;

        private IList<T> NonEmptyItems => _items ?? Array.Empty<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return NonEmptyItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => NonEmptyItems.Count;

        public T this[int index] => NonEmptyItems[index];

        void ICollection<T>.Add(T item)
        {
            throw new NotSupportedException("This is an immutable collection, no changes allowed.");
        }

        void ICollection<T>.Clear()
        {
            throw new NotSupportedException("This is an immutable collection, no changes allowed.");
        }

        bool ICollection<T>.Contains(T item)
        {
            return NonEmptyItems.Contains(item);
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            NonEmptyItems.CopyTo(array, arrayIndex);
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotSupportedException("This is an immutable collection, no changes allowed.");
        }

        bool ICollection<T>.IsReadOnly => true;

        int IList<T>.IndexOf(T item)
        {
            return NonEmptyItems.IndexOf(item);
        }

        void IList<T>.Insert(int index, T item)
        {
            throw new NotSupportedException("This is an immutable collection, no changes allowed.");
        }

        void IList<T>.RemoveAt(int index)
        {
            throw new NotSupportedException("This is an immutable collection, no changes allowed.");
        }

        T IList<T>.this[int index]
        {
            get => this[index];
            set => throw new NotSupportedException("This is an immutable collection, no changes allowed.");
        }

        #region Operators

        public static Lst<T> operator +(Lst<T> a, Lst<T> b) => new Lst<T>(a.Concat(b).ToArray());

        public static Lst<T> operator +(Lst<T> list, T item) => list + new Lst<T>(item);

        public static Lst<T> operator +(T item, Lst<T> list) => list + item;

        public static implicit operator T[](Lst<T> list) => list.ToArray();

        public static implicit operator Lst<T>(T item) => new Lst<T>(item);

        #endregion

        public bool Equals(Lst<T> other)
        {
            return NonEmptyItems.SequenceEqual(other.NonEmptyItems);
        }

        public override bool Equals(object obj)
        {
            return obj is Lst<T> other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _items?.GetHashCode() ?? 0;
        }
    }

    public static class Lst
    {
        public static Lst<T> Create<T>(T item) => new Lst<T>(item);

        public static Lst<T> CreateWithoutNulls<T>(params T[] items) => new Lst<T>(items?.Where(item => item != null).ToArray());
    }
}