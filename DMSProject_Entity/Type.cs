namespace DMSProject_Entity
{
    public class Type
    {
        public int TypeId { get; set; }
        public required string Name { get; set; }
        public List<FileTable>? Files { get; set; }
    }
}