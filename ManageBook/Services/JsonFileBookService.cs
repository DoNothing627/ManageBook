using ManageBook.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
//using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace ManageBook.Services
{
    public class JsonFileBookService
    {
        public JsonFileBookService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "books.json"); }
        }

        public IEnumerable<Books> GetBooks()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return System.Text.Json.JsonSerializer.Deserialize<Books[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void AddRating(string BookId, int rating)
        {
            var book = GetBooks();
            if(book.First(x=> x.Id== BookId).Rate== null)
            {
                book.First(x => x.Id == BookId).Rate = new int[] {rating};
            }
            else 
            {
                var ratings = book.First(x => x.Id == BookId).Rate.ToList();
                ratings.Add(rating);
                book.First(x => x.Id == BookId).Rate = ratings.ToArray();
            }

            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                System.Text.Json.JsonSerializer.Serialize<IEnumerable<Books>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    book
                );
            }
        }

        public void AddNewBook(string BookId, string BookName, string BookImg, string BookDescription, int BookNumberOfThisBook)
        {
            var book= GetBooks();
            var list = JsonConvert.DeserializeObject<List<Books>>(JsonFileName);
            list.Add(new Books(BookId, BookName, BookImg, BookDescription, null, BookNumberOfThisBook));
            var convertedJson = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                System.Text.Json.JsonSerializer.Serialize<IEnumerable<Books>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    book
                );
            }
        }

        public void UpdateBook(string BookId, bool type, string name, string gmail, string phoneNumber)
        {
            var book = GetBooks();
            Books SelectedBook= book.First(x => x.Id == BookId);
            //SelectedBook.NumberOfThisBook += type;

            string[] detail= new string[3];
                detail[0]= name;
                detail[1]= gmail;
                detail[2]= phoneNumber;

            if(type== true)
                SelectedBook.Detail.Add(detail);

            else
                SelectedBook.Detail.Remove(detail);

            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                System.Text.Json.JsonSerializer.Serialize<IEnumerable<Books>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    book
                );
            }

        }
    }
}
