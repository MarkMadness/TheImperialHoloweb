using System.ComponentModel.DataAnnotations;

namespace TheImperialHoloweb.Models.Military
{
    public class MilitaryApplicationViewModel
    {
        // Personal Information
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Middle Name")]
        public string? MiddleName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress, Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Phone, Display(Name = "Comm Channel Number (Phone)")]
        public string? Phone { get; set; }

        [Required, Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        [Display(Name = "Species")]
        public string? Species { get; set; }

        [Display(Name = "Home Planet")]
        public string? HomePlanet { get; set; }

        // Background
        [Display(Name = "Citizenship Status")]
        public string? CitizenshipStatus { get; set; }

        [Display(Name = "If Other, describe")]
        public string? CitizenshipOther { get; set; }

        [Display(Name = "Education Level")]
        public string? EducationLevel { get; set; }

        [Display(Name = "Current Occupation")]
        public string? CurrentOccupation { get; set; }

        // Physical Attributes
        [Display(Name = "Height (Feet)")]
        public int HeightFeet { get; set; } = 5;

        [Display(Name = "Height (Inches)")]
        public int HeightInches { get; set; } = 8;

        [Display(Name = "Weight Range")]
        public string? WeightRange { get; set; }

        [Display(Name = "Number of Arms")]
        public int NumberOfArms { get; set; } = 2;

        [Display(Name = "Number of Legs")]
        public int NumberOfLegs { get; set; } = 2;

        // Military & Combat
        [Display(Name = "Prior Military Service")]
        public bool HasPriorMilitaryService { get; set; }

        [Display(Name = "Military Service Details")]
        public string? PriorMilitaryDetails { get; set; }

        [Display(Name = "Firearms / Weapons Experience")]
        public bool HasFirearmsExperience { get; set; }

        [Display(Name = "Weapon Types Experienced")]
        public List<string> FirearmsTypes { get; set; } = new();

        [Display(Name = "Firearms Expertise Levels")]
        public List<int> FirearmsLevels { get; set; } = new();

        [Range(1, 5), Display(Name = "Physical Fitness Level")]
        public int PhysicalFitnessLevel { get; set; } = 3;

        // Technical Skills
        [Display(Name = "Computer / Slicing Proficiency")]
        public string? ComputerKnowledgeLevel { get; set; }

        [Display(Name = "Biotech / Medical Knowledge")]
        public string? BiotechKnowledgeLevel { get; set; }

        [Display(Name = "Piloting Experience")]
        public bool HasPilotingExperience { get; set; }

        [Display(Name = "Vessel / Craft Types Operated")]
        public List<string> VesselTypes { get; set; } = new();

        [Display(Name = "Vessel Proficiency Levels")]
        public List<int> VesselLevels { get; set; } = new();

        [Display(Name = "Engineering / Technical Aptitude")]
        public string? EngineeringLevel { get; set; }

        // Imperial Allegiance
        [Display(Name = "Previous Rebel / Terrorist Affiliation")]
        public bool HasRebelAffiliation { get; set; }

        [Display(Name = "Rebel / Terrorist Organization")]
        public string? RebelOrganization { get; set; }

        [Display(Name = "Organization Name (if Other)")]
        public string? RebelOrganizationOther { get; set; }

        [Display(Name = "Role in Organization")]
        public string? RebelRole { get; set; }

        [Display(Name = "If Other, what was your role title?")]
        public string? RebelRoleOther { get; set; }

        [Display(Name = "Nature of Involvement")]
        public string? RebelInvolvementDetails { get; set; }

        [Display(Name = "Motivations for Enlisting")]
        public List<string> EnlistingMotivations { get; set; } = new();

        [Display(Name = "Preferred Military Division")]
        public string? PreferredDivision { get; set; }

        [Display(Name = "Force Sensitivity")]
        public string? ForceSensitivity { get; set; }

        [Display(Name = "Hyperspace Navigation Knowledge")]
        public bool HasHyperspaceKnowledge { get; set; }

        [Display(Name = "Statement of Allegiance")]
        public string? AllegianceStatement { get; set; }
    }
}
