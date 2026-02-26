using Hospital.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Hospital.Contract
{
 
public interface ICurrentUserService
{
    Guid Id { get; }
    string Name { get; }
    string Role { get; }
        Language Language { get; }
    List<Permission> Permissions { get; }
    bool HasPermission(Permission permission);
}
}