using System;
using System.Collections.Generic;
using System.Text;
using DersTekrar.Models;

namespace DersTekrar.ViewModels
{
    public class StudentViewModel
    {
        //alt seviye encapculation
        public List<Student> Students { get; set; }
       

        public StudentViewModel()
        {
            Students = new List<Student>
            {
                new Student{Name = "Ebrar",Surname = "Tepeciklioplu"},
                new Student{Name = "Sıla",Surname = "Özyeşil"},
                new Student{Name = "Mustafa",Surname = "Hiçyılmaz"},
            };
        }
    }
}
