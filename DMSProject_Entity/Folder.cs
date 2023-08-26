using DMSProject_Entity.Juction_Tables;

namespace DMSProject_Entity
{
    public class Folder
    {
        public int FolderId { get; set; }
        public required string FolderName { get; set; }
        public string? FolderDescription { get; set; }
        public required string FolderPath { get; set; }
        public int? ParentFolderId { get; set; }
        public Folder? ParentFolder { get; set; }
        public List<Folder>? SubFolders { get; set; }
        public List<UserFolder>? UserFolders { get; set; }
        public List<FileTable>? Files { get; }
        public List<FolderTag>? FolderTags { get; set; }
        public required string CreatedById { get; set; }
        public required User CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public required string ModifiedById { get; set; }
        public required User ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}