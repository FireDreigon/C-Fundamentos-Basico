using System;
using Xunit;

namespace GradeBook.Test
{
    public class TypeTest
    {
        [Fact]
        public void Test1()
        { 

          var book1 = GetBook("Book 1"); 
          var book2 = GetBook("Book 2"); 
 
        
          Assert.Same("Book 1",book1.Name);
          Assert.Same("Book 2",book2.Name);
        }

        private Book GetBook(string name)
        {
           return new Book(name);
        }
    }
}
