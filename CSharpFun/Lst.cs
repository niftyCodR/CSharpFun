using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFun
{
    /// <summary>
    /// Represents a readonly collection of items.
    /// </summary>
    public struct Lst<T> : IReadOnlyList<T>, IEquatable<Lst<T>>
    {
        private readonly IReadOnlyList<T> _items;
        
        public Lst(params T[] items)
        {
            if(items == null || items.Any(err => ReferenceEquals(null, err)))
                throw new ArgumentNullException(nameof(items), $"{nameof(Lst<T>)} does not support null values.");

            _items = items.ToArray();
        }

        public bool IsEmpty => Count == 0;

        private IReadOnlyList<T> NonEmptyItems => _items ?? Array.Empty<T>();

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

        #region Operators

        public static Lst<T> operator +(Lst<T> a, Lst<T> b) => new Lst<T>(a.Concat(b).ToArray());

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

        public static implicit operator Lst<T>(T item) => new Lst<T>(item);
    }

    public static class Lst
    {
        public static Lst<T> Create<T>(T item) => new Lst<T>(item);
    }
}