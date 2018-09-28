using System.Collections.Generic;
using ProjectManagementApp.Models;

public class ProjectAddUserViewModel
    {
        public string UserId { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }