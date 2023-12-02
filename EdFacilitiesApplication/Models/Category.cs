using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EdFacilitiesApplication.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();
}
