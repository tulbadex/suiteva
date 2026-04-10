# Suiteva — Project Progress & Reference

## Brand Identity

| Property | Value |
|----------|-------|
| **Name** | Suiteva |
| **Tagline** | Where Every Stay Feels Suite |
| **Domain** | Suiteva & Management Platform |
| **Author** | Ibrahim |
| **GitHub** | https://github.com/tulbadex/suiteva |
| **Contact** | ibrahimadedayo@rocketmail.com |

### Color Palette

| Color | Hex | Usage |
|-------|-----|-------|
| Deep Ocean Blue | `#0F4C75` | Primary — headers, nav, buttons |
| Amber Gold | `#E8A838` | Accent — highlights, CTAs, badges |
| Ice White | `#F7F9FC` | Background — light sections |
| Midnight | `#1A1A2E` | Dark backgrounds, footer |

### Typography
- **Headings**: Inter or Roboto
- **Body**: System sans-serif stack

---

## Architecture

```
Suiteva/
├── suiteva-client/                # Angular 19 SPA Frontend
│   ├── src/app/
│   │   ├── features/            # Feature modules (admin, billing, hotel, reservation)
│   │   ├── guards/              # Auth guards
│   │   ├── interceptors/        # JWT interceptor
│   │   ├── layout/              # Dashboard layout
│   │   ├── models/              # TypeScript interfaces
│   │   ├── pages/               # Auth pages (login, register), welcome
│   │   └── services/            # API services
│   └── public/                  # Static assets, favicon
├── Suiteva.API/                 # ASP.NET Core Web API Backend
│   ├── Controllers/             # API endpoints
│   ├── Data/                    # DbContext, seeder
│   ├── DTOs/                    # Data transfer objects
│   ├── Helpers/                 # JWT helper
│   ├── Middleware/               # Exception handling
│   ├── Models/                  # Entity models
│   ├── Repositories/            # Generic repository + Unit of Work
│   └── Services/                # Business logic layer
├── Suiteva.Tests/     # Unit tests (NUnit + Moq)
├── docs/                        # Documentation
│   ├── IMAGE_PROMPTS.md
│   └── PROGRESS.md
└── README.md
```

### Key Patterns
- **JWT Authentication** — login/register with role-based access
- **Generic Repository + Unit of Work** — abstracted data access
- **Service Layer** — business logic decoupled from controllers
- **Auth Guards + Interceptors** — Angular route protection + auto token attachment
- **Feature-based Angular modules** — admin, billing, hotel, reservation
- **Background Services** — notification processing
- **Exception Middleware** — centralized error handling

---

## Tech Stack

| Layer | Technology |
|-------|-----------|
| Frontend | Angular 19, Angular Material, TypeScript |
| Backend | ASP.NET Core Web API (.NET 8) |
| Database | SQL Server (LocalDB) |
| Auth | JWT (JSON Web Tokens) |
| ORM | Entity Framework Core |
| Testing | NUnit, Moq |
| Patterns | Repository, Unit of Work, Service Layer, DTOs |

---

## Progress Tracker

### Phase 1 — Rebrand
- [ ] Rename Suiteva.API → Suiteva.API
- [ ] Rename suiteva-client → suiteva-client
- [ ] Rename Suiteva.Tests → Suiteva.Tests
- [ ] Update all namespaces and references
- [ ] Update README.md
- [ ] Replace images and logo
- [ ] Update Angular title, favicon, branding
- [ ] Update connection string → LocalDB
- [ ] Update seeded user credentials

### Phase 2 — Upgrade & Polish
- [ ] Upgrade to latest .NET 8 packages
- [ ] Upgrade Angular packages if needed
- [ ] Update brand colors in Angular Material theme
- [ ] Add favicon links to index.html
- [ ] Update login/register pages with branding
- [ ] Fresh migrations for LocalDB

### Phase 3 — GitHub
- [ ] Fresh git repo (zero history)
- [ ] Push to https://github.com/tulbadex/suiteva
- [ ] Add topics

---

## Seeded Users

| Username | Password | Role |
|----------|----------|------|
| admin | Admin@123 | Admin |
| manager | Manager@123 | HotelManager |
| receptionist | Reception@123 | Receptionist |
| guest | Guest@123 | Guest |

---

## Database

| Property | Value |
|----------|-------|
| Provider | SQL Server LocalDB |
| Connection | `Server=(localdb)\MSSQLLocalDB;Database=SuitevaDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True` |

---

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/api/auth/register` | Register new user |
| POST | `/api/auth/login` | Login, returns JWT |
| GET | `/api/hotels` | List all hotels |
| GET | `/api/rooms` | List rooms (with filters) |
| POST | `/api/reservations` | Create reservation |
| GET | `/api/reservations` | List reservations |
| GET | `/api/bills` | List bills |
| GET | `/api/users` | List users (admin) |
| GET | `/api/seasonal-rates` | List seasonal rates |

---

## Changelog

| Date | Change |
|------|--------|
| *(today)* | Project cloned, docs created, image prompts ready |
