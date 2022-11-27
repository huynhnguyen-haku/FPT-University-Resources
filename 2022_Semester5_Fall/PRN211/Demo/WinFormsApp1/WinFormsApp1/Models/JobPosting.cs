using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class JobPosting
{
    public int PostingId { get; set; }

    public string JobPostingTitle { get; set; }

    public string Description { get; set; }

    public DateTime PostedDate { get; set; }

    public virtual ICollection<CandidateProfile> CandidateProfiles { get; } = new List<CandidateProfile>();
}
