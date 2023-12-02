using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EdFacilitiesApplication.Models;

public partial class Facility
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Location { get; set; } = null!;

    [JsonIgnore]
    public virtual Category Category { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<History> Histories { get; set; } = new List<History>();
}
