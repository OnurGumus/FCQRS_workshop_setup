# Workshop setup — starting skeleton

The **starting point** for the *focument* CQRS + Event Sourcing workshop (built on
[FCQRS](https://github.com/onurgumus/FCQRS), C# 15 `union` types). It's the project
scaffolding only — solution, projects, package references, the static UI and the
container config — with **no domain code yet**. We build that together, piece by
piece, during the session.

## Before the workshop — verify your setup

You need the **.NET 11 SDK (preview)** — C# 15 `union` needs `LangVersion preview`;
`global.json` pins the band. No .NET locally? Use a container, zero setup:

- **GitHub Codespaces:** [![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/OnurGumus/FCQRS_workshop_setup)
- **VS Code:** *Dev Containers: Reopen in Container* (uses `.devcontainer/`).

Then:

```bash
git clone https://github.com/OnurGumus/FCQRS_workshop_setup.git
cd FCQRS_workshop_setup
dotnet run --project src/Server
```

The first run **restores packages** (do this ahead of time — it's the slow part) and
builds. When the console prints `Now listening on: http://localhost:5000`, open it.
You'll see the UI shell; it has no data and the buttons hit an API we haven't built —
**that's expected.** If the page loads and the build is clean, you're ready:

```bash
dotnet build      # should succeed
dotnet test       # runs one setup smoke test (confirms the test toolchain)
```

## What's here vs what we'll build

**Given** (the slow, not-the-lesson bits): the solution + three projects with all
package references, `global.json`, `.devcontainer/` + Codespaces, the `wwwroot/` UI,
the console log formatter + `appsettings.json`, and a minimal `Program.cs` that
serves the static files.

**We build live:** the domain model (value objects, commands / events / state), the
`Document` and `User` aggregates (`decide` / `fold`), the quota saga, the projection,
the HTTP endpoints, the DI wiring, and the tests.

---

> **Maintainer note.** This skeleton is derived from
> [focument_workshop](https://github.com/OnurGumus/focument_workshop) — the completed
> reference app and the `baseline-no-saga → master` answer key. If you bump packages
> or the SDK there, regenerate this repo to match.
