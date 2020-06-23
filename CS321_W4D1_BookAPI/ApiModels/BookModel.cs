using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; internal set; }
        public string Genre { get; internal set; }
        public string OriginalLanguage { get; internal set; }
        public int PublicationYear { get; internal set; }
        public int PublisherId { get; internal set; }
        public string Publisher { get; internal set; }
        public int AuthorId { get; internal set; }
        public string Author { get; internal set; }
        // TODO: fill in BookModel properties
    }
}
