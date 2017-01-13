using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxWithLink
{
    public class MainWindowViewModel
    {
        public List<Employee> Employees { get; set; }

        public MainWindowViewModel()
        {
            //Load Sample Text
            Employees = new List<Employee>();
            Employees.Add(new Employee { Name = "Name 1", Details = "Lorem Ipsum is simply dummy text of the *Peter and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Employees.Add(new Employee { Name = "Name 2", Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Employees.Add(new Employee { Name = "Name 3", Details = "Lorem Ipsum is simply dummy text of the printing and *Peter industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Employees.Add(new Employee { Name = "Name 4", Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. *Peter Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Employees.Add(new Employee { Name = "Name 5", Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Employees.Add(new Employee { Name = "Name 6", Details = "Lorem *Peter is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Employees.Add(new Employee { Name = "Name 7", Details = "Lorem Ipsum is simply dummy text of the *Peter and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
        }


    }
}
