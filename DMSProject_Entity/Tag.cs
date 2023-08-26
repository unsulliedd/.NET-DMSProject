using DMSProject_Entity.Juction_Tables;

namespace DMSProject_Entity
{
    public class Tag
    {
        public int TagId { get; set; }
        public required string Name { get; set; }
        public List<FileTableTag>? FileTags { get; set; }
        public List<FolderTag>? FolderTags { get; set; }
    }
}
