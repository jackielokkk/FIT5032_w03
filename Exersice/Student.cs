using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Week03.Exersice
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public Student(String name, String phoneNumber) 
    { 
        Name = name; 
        PhoneNumber = phoneNumber; 
    }


    public class ExampleDictionary
    {
        public void Example() 
        { 
            Dictionary<int, Student> studentDictionary = newDictionary<int, Student>(); 
            Student s1 = newStudent("Alex", "0431170991"); 
            Student s2 = newStudent("Kim", "0431170992"); 
            studentDictionary.Add(1, s1); studentDictionary.Add(2, s2); 
            Student result = newStudent("", ""); 
            studentDictionary.TryGetValue(1, out result); 
        }
}
}