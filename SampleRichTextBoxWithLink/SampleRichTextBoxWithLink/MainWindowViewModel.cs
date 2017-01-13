using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxWithLink
{
    public class MainWindowViewModel
    {
        public List<Automobile> Automobiles { get; set; }

        public MainWindowViewModel()
        {
            //Load Sample Text
            Automobiles = new List<Automobile>();
            Automobiles.Add(new Automobile { Name = "Name 1", Details = "Lorem Ipsum is simply dummy text of the #Fiat and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Automobiles.Add(new Automobile { Name = "Name 2", Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Automobiles.Add(new Automobile { Name = "Name 3", Details = "Lorem Ipsum is simply dummy text of the printing and #Skoda industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Automobiles.Add(new Automobile { Name = "Name 4", Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. #Ford Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Automobiles.Add(new Automobile { Name = "Name 5", Details = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Automobiles.Add(new Automobile { Name = "Name 6", Details = "Lorem #BMW is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
            Automobiles.Add(new Automobile { Name = "Name 7", Details = "Lorem Ipsum is simply dummy text of the #Dodge and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });
        }


    }
}
