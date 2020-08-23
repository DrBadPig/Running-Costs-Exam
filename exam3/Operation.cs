using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam3
{
    /// <summary>
    /// This class is item in listView 
    /// </summary>
    class Operation
    {
        int id;
        DateTime date;
        string title;
        double price;
        string description;
        string member;
        string category;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Title { get => title; set => title = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public string Member { get => member; set => member = value; }
        public string Category { get => category; set => category = value; }
    }
}
