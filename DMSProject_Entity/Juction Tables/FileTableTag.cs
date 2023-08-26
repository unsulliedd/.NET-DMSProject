namespace DMSProject_Entity.Juction_Tables
{
    public class FileTableTag
    {
        public int FileId { get; set; }
        public required FileTable File { get; set; }
        public int TagId { get; set; }
        public required Tag Tag { get; set; }
    }
}