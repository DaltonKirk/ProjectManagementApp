using System.ComponentModel.DataAnnotations;
namespace ProjectManagementApp.Models
{
    public enum ProjectStage { PreProduction, PreAlpha, Alpha, Beta, Master, Launch, LiveOps };

    public class Project {
        [Key]
        public int Id {get;set;}

        public string Name {get;set;}
        public string Description { get; set; }

        public ProjectStage Stage { get; set; }
    }
}