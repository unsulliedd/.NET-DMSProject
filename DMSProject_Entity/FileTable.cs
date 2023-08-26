using DMSProject_Entity.Juction_Tables;

namespace DMSProject_Entity
{
    public class FileTable
    {
        public int FileId { get; set; }
        public required string FileName { get; set; }
        public string? FileDescription { get; set; }
        public required string FilePath { get; set; }
        public long FileSize { get; set; }
        public int TypeId { get; set; }
        public required Type FileType { get; set; }
        public int FolderId { get; set; }
        public required Folder Folder { get; set; }
        public required List<UserFileTable> UserFiles { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<FileTableTag>? FileTags { get; set; }
        public required string CreatedById { get; set; }
        public required User CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public required string ModifiedById { get; set; }
        public required User ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
