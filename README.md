# Quick Start Guide for Kazka API

## Step 1: Install Required Software
1. Install [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
2. Install [PostgreSQL](https://www.postgresql.org/download/)

```powershell
dotnet --version
```

- (Optional) Visual Studio 2022/2023 or VS Code with C# extensions for IDE experience.
- If running EF Core migrations locally: the `dotnet-ef` tool:

## Step 2: Database Setup
1. Create a new PostgreSQL database
2. Open `Kazka.Api/appsettings.json`
3. Replace empty connection string with yours:
```json
"ConnectionStrings": {
    "PostgreSQL": "Host=localhost;Port=5432;Database=your_db_name;Username=your_username;Password=your_password"
}
```

## Step 3: Apply Database Migrations
Open PowerShell in the project root folder and run:
```powershell
dotnet tool install --global dotnet-ef
$env:ASPNETCORE_ENVIRONMENT = 'Development'
dotnet ef database update --project .\Kazka.Persistence\ --startup-project .\Kazka.Api\
```

## Step 4: Run the API
In the same PowerShell window:
```powershell
$env:ASPNETCORE_ENVIRONMENT = 'Development'
dotnet run --project .\Kazka.Api\
```

## Step 5: Test the API
1. Open Swagger UI: https://localhost:7209/swagger
2. All endpoints require `/api/v1/` prefix, for example:
   - Stories list: https://localhost:7209/api/v1/stories
   - User profile: https://localhost:7209/api/v1/users/me

## Common Problems
1. **404 Error**: Add `/api/v1/` to the URL
2. **Database Error**: Check connection string in `appsettings.json`
3. **Authorization Error**: Most endpoints need a token in the request header
4. **Can't see Swagger**: Make sure you set `ASPNETCORE_ENVIRONMENT=Development`

## Need More Details?

For advanced configuration, troubleshooting, and detailed API documentation:
1. See `ENDPOINTS.md` for complete API documentation
2. Check `Kazka.Api/appsettings.json` for all configuration options
3. View endpoint implementations in `Kazka.Api/Endpoints/` folder

---

## Common issues & troubleshooting

- 404 while Swagger shows the route:
	- Missing version prefix (`/api/v1`) in your request path.
	- Wrong port or protocol (https vs http).
	- Copy the exact path from Swagger UI including the version prefix.

- Authorization errors:
	- Protected endpoints require a valid Authorization header; lack of token usually results in `401` or `403`.

- CORS errors (from browser/frontend):
	- Ensure `Cors` policy in `appsettings.json` is configured to allow your frontend origin.

- Database connection errors:
	- Verify `ConnectionStrings:PostgreSQL` and that the DB server is reachable.

- Incomplete handlers:
	- Some endpoint implementations are incomplete or placeholders (e.g., `UpdateStory`, `GetChaptersSummary`, `GetChapterParagraphs`, `UpdateUserRole`). They may not behave as expected until finished.

- Google OAuth not redirecting:
	- Ensure `Authentication:RedirectUrl` and `Google:CallbackPath` are configured and the Google console has the correct redirect URI.

---

## Convenience script (optional)

You can create a simple PowerShell script `run-local.ps1` to start the app quickly. Example content:

```powershell
# run-local.ps1
$env:ASPNETCORE_ENVIRONMENT='Development'
dotnet build .\ChildrenFairyTaleBackend.sln
dotnet run --project .\Kazka.Api\ --launch-profile "https"
```

Run with:

```powershell
.\run-local.ps1
```

---