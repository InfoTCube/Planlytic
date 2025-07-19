using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace API.Entities;

public class AppUser : IdentityUser
{
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}