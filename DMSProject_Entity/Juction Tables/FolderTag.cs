namespace DMSProject_Entity.Juction_Tables
{
    public class FolderTag
    {
        public int FolderId { get; set; }
        public required Folder Folder { get; set; }
        public int TagId { get; set; }
        public required Tag Tag { get; set; }
    }
}