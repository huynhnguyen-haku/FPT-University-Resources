using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class CandidateProfile
{
    public int CandidateId { get; set; }

    public string Fullname { get; set; }

    public DateTime Birthday { get; set; }

    public string ProfileShortDescription { get; set; }

    public string ProfileUrl { get; set; }

    public int PostingId { get; set; }

    public virtual JobPosting Posting { get; set; }
}
