using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    { 
        
        private List<double> grades; 
        public string Name;

        public Book(string name)
        { 
            this.Name = name;
            grades=new List<double>();
        }
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics(); 
            result.High = double.MinValue; 
            result.Low = double.MaxValue; 

            foreach(var numbre in grades)
            {
                result.Low = Math.Min(numbre, result.Low);
                result.High = Math.Max(numbre, result.High); 
                result.Avarage += numbre;
            } 

            result.Avarage /= grades.Count; 
            
            return result;

        } 
    }
}