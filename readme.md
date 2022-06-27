
# Paging lib fot .net projects
## Installation
- [Nuget page](https://www.nuget.org/packages/FabioGilberto.Paging/)

- Nuget package manager:
```bash
Install-Package FabioGilberto.Paging -Version 1.0.0
```
- .Net CLI:
```bash
dotnet add package FabioGilberto.Paging --version 1.0.0
```
## Usage

```csharp
# Basic utilization:

using FabioGilberto.Paging;

var enumerable = new List<string>().AsEnumerable();

var pagedPropeties = new PagingPropeties(1, 10);

var pagesEnumerable = enumerable.AsPagedEnumerable(pagedPropeties);
```

```csharp
# Repository example:

using FabioGilberto.Paging;

public class UsersRepository
{
    private readonly ApplicationDbContext _db;

    public UsersRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public IPagedQueryable<ApplicationUser> Read(PagingPropeties pagedPropeties)
    {
        var usersQuery = _db.Users.AsQueryable();   

        return usersQuery.AsPagedQueryable(pagedPropeties);
    }
}
```