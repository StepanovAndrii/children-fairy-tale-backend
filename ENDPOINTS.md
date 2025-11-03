# API Endpoints

This document contains a consolidated reference of the endpoints implemented in the `Kazka.Api` project (generated from the code under `Kazka.Api/Endpoints`).

> Version prefix: `/api/v1` (read from `ApiSettings:Version` in `appsettings.json`).

## General notes
- All endpoints are mapped into a versioned group `/{ApiSettings.Version}` and by default require authorization (`RequireAuthorization()`).
- Admin endpoints are marked with the `[AdminEndpoint]` attribute and are mapped under `/admin` inside the versioned prefix (full paths start with `/api/v1/admin/...`). Access to admin endpoints requires the `AdminOnly` policy (role `Admin`).
- Some endpoints may be explicitly allowed for anonymous access via `.AllowAnonymous()` (for example, `auth/google`).

---

## Endpoints list

### 1) GetStoriesSummary
- Method: GET
- Path: `/api/v1/stories`
- Auth: Required (Bearer token)
- Query parameters:
  - `CategoryId` (uint?)
  - `Limit` (uint?)
  - `Offset` (uint?)
- Response: `200 OK` with a collection of story summaries (result of `IStoryBusinessLogic.GetAllStories()`).

### 2) GetChaptersSummary
- Method: GET
- Path: `/api/v1/stories/{storyId}/categories`
- Path params:
  - `storyId` (uint)
- Auth: Required
- Response: `200 OK` (implementation in code is empty — check service logic).

### 3) GetChapterParagraphs
- Method: GET
- Path: `/api/v1/stories/{storyId}/categories/{categoryId}/paragraphs`
- Path params:
  - `storyId` (uint)
  - `categoryId` (uint)
- Auth: Required
- Response: `200 OK` (implementation in code is empty — check service logic).

### 4) CreateStory
- Method: POST
- Path: `/api/v1/stories`
- Body (JSON): `CreateStoryRequestDto`
  - Title (string)
  - Description (string | nullable)
  - CategoryId (uint)
  - CoverPath (string | nullable)
  - LanguageId (uint)
  - Chapters (array of `ChapterDto`)
- Auth: Required
- Response: `201 Created` with Location `/{apiVersion}/stories/{id}` and the created resource in the body.

### 5) GetUserInfo
- Method: GET
- Path: `/api/v1/users/me`
- Auth: Required — checks `ICurrentUserService.GoogleId` and returns `401 Unauthorized` if null.
- Response: `200 OK` with `UserProfileResponseDto` or `401 Unauthorized`.

### 6) UpdateUserInfo
- Method: PATCH
- Path: `/api/v1/users/me`
- Body (JSON): `UpdateUserRequestDto`
  - Name (string | nullable)
  - Age (int | nullable)
  - ProfilePictureUrl (string | nullable)
- Auth: Required
- Response: `200 OK` with updated profile or `204 NoContent` (code returns NoContent when result is null).

### 7) GetUsers (Admin)
- Method: GET
- Path: `/api/v1/admin/users`
- Auth: Required, role `Admin` (policy `AdminOnly`).
- Response: `200 OK` with `UsersResponseDto` or `204 NoContent`.

### 8) UpdateUserRole (Admin)
- Method: PATCH
- Path: `/api/v1/admin/users/{id}/role`
- Path params:
  - `id` — user identifier
- Body (JSON): `UpdateUserRoleRequestDto` (e.g. `{ "role": "Admin" }`)
- Auth: Required, role `Admin`.
- Response: implementation in code is empty — verify the handler.

### 9) UpdateStory
- Method: PATCH
- Path: `/api/v1/stories/{id}`
- Path params:
  - `id` — story id
- Body (JSON): `UpdateStoryRequestDto` (fields are nullable for partial updates)
- Auth: Required
- Note: the method implementation in code appears incomplete (`var command = d`), so this endpoint may not be functional until finished.

### 10) ChallengeGoogle
- Method: GET
- Path: `/api/v1/auth/google`
- Description: Initiates OAuth challenge using the `Google` authentication scheme. Uses `Authentication:RedirectUrl` from configuration.
- Auth: Allowed anonymously (`AllowAnonymous()`).

---

## Debugging tips for 404 responses
1. Make sure you are calling the exact path including the version prefix: `/api/v1/...`.
2. Admin endpoints live under `/api/v1/admin/...` (so `/api/v1/users` is not the same as `/api/v1/admin/users`).
3. If Swagger shows the route but an external request returns 404, check:
   - base URL and port (HTTP vs HTTPS)
   - exact path — copy it from Swagger
   - HTTP method (GET/POST/PATCH)
   - Authorization header (protected routes require a valid token)
4. Several handlers in the code are incomplete (UpdateStory, GetChaptersSummary, GetChapterParagraphs, UpdateUserRole) — verify their implementations before relying on them.