namespace OneToManyRelationshipsFluentApi.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Company Company { get; set; } = null!;
    }
}
