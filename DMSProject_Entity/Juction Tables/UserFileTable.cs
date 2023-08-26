namespace DMSProject_Entity.Juction_Tables
{
    public class UserFileTable
    {
        public required string UserId { get; set; }
        public required User User { get; set; }
        public int FileId { get; set; }
        public required FileTable File { get; set; }
        public bool IsOwner { get; set; }
        public bool HasPermission { get; set; }
        public bool CanView { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanDownload { get; set; }
        public bool CanUpload { get; set; }
    }
}