using System;

namespace IT_13FinalProject.Models
{
    public class NurseNote
    {
        public int NurseNoteId { get; set; }

        public int PatientId { get; set; }

        public Patient? Patient { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Details { get; set; } = string.Empty;

        public string NurseName { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public bool IsArchived { get; set; }

        public DateTime? ArchivedAt { get; set; }
    }
}
