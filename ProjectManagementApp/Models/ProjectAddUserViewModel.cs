using System.Collections.Generic;
using ProjectManagementApp.Models;

public class ProjectAddUserViewModel
    {
        public int Id { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }