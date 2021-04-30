using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ManageBook.Models
{
    public class Books
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Descripstion { get; set; }
        public int[] Rate { get; set; }
        public int NumberOfThisBook { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Books>(this);

        public Books(string id, string name, string img, string descripstion, int[] rate, int numberOfThisBook)
        {
            Id = id;
            Name = name;
            Img = img;
            Descripstion = descripstion;
            Rate = rate;
            NumberOfThisBook = numberOfThisBook;
        }
    }
}
