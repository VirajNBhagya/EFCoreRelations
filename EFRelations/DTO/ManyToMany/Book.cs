namespace EFRelations.DTO.ManyToMany
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }

        public ICollection<Genre> Genres { get; set; }
    }
}
