using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace My.Epi.Project.Web.Website.Models.Blocks
{
    [ContentType(
        DisplayName = "My Block",
        GUID = "84C4B78A-DE45-4335-B2CB-3DFA64C0801B")]
    public class MyBlockType : BlockData
    {
        [Display(
            Name = "Name",
            Description = "Some Description that should show up",
            Order = 10)]
        public virtual string Name { get; set; } // Description issue only on Field Name

        [Display(
            Name = "Other Name",
            Description = "Some Description that should show up",
            Order = 20)]
        public virtual string OtherName { get; set; } // Description showing up correctly
    }
}