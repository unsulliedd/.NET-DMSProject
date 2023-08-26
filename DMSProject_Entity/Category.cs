namespace DMSProject_Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string Name { get; set; }
        public List<FileTable>? Files { get; set; }
    }
}
