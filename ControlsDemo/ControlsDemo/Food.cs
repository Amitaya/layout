using System;
using System.Collections.Generic;
using System.Text;

namespace ControlsDemo
{
    public class Food
    {
        public string ImageURL { 
            get {
                return "https://cdn.pixabay.com/photo/2018/08/20/17/04/wedding-3619423_1280.png";
            } set { } }

        public string Name { set; get; }

        public string Type { set; get; }
    }

    public class Todd
    {
        public int ID { set; get; }
    }

    public class Meda { }
}
