namespace OneToOneRelationshipsFluentApi.Entitites
{
    public class Biography
    {
        public int BiographyId { get; set; }
        public string BiographyDescription { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public int AuthorRef { get; set; }
        public Author Author { get; set; } = null!;
    }
}
