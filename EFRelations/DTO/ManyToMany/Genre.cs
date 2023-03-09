﻿namespace EFRelations.DTO.ManyToMany
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }


        public ICollection<Book> Books { get; set; }
    }
}
