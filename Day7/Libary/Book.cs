using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    public class Book : IEquatable<Book>, IComparable<Book>, IComparable
    {
        public string Author { get;}

        public string Title { get;}
        public int Id { get;}
        public int NumberOfPages { get; }

        public int CompareTo(Book other)
        {
            if (ReferenceEquals(other, null)) return -1;
            if (this.Id > other.Id) return 1;
            else if (this.Id < other.Id) return -1;
            return 0;
        }

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(obj,null)) return 1;
            Book book = obj as Book;
            if (book != null)
                return this.Id.CompareTo(book.Id);
            else
                throw new ArgumentException($"Object is not a {nameof(Book)}");
        }

        public bool Equals(Book obj)
        {
            if (ReferenceEquals(obj, null) || !(obj is Book))
                return false;
            else
                return ReferenceEquals(this, ((Book)obj));
        }

        public override int GetHashCode()
        {
            return Author.GetHashCode() + Title.GetHashCode()
                + NumberOfPages.GetHashCode() + Id.GetHashCode();
        }

    }

}
