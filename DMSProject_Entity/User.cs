using DMSProject_Entity.Juction_Tables;
using Microsoft.AspNetCore.Identity;

namespace DMSProject_Entity
{
    public class User : IdentityUser
    {
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public List<FileTable>? CreatedFiles { get; set; }
        public List<FileTable>? LastModifiedFiles { get; set; }
        public List<Folder>? CreatedFolders { get; set; }
        public List<Folder>? LastModifiedFolders { get; set; }
        public List<UserFileTable>? UserFiles { get; set; }
        public List<UserFolder>? UserFolders { get; set; }
    }
}