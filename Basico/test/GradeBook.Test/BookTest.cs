using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTest
    {
        [Fact]
        public void BookCalculatesAnAvatageGrade()
        { 

            //arrange 
            var book = new Book(""); 

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(79.8);
            book.AddGrade(85.6); 

            //act 
            var result = book.GetStatistics();

            //Object
            Object.Equals(85.6,result.Avarage);
            Object.Equals(90.5,result.High);
            Object.Equals(79.8,result.High);
        }
    }
}
