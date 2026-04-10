# Suiteva — Where Every Stay Feels Suite

A full-stack hotel reservation and management platform built with **Angular 19** and **ASP.NET Core Web API (.NET 9)**. Features JWT authentication, role-based access control, room booking, billing, seasonal rates, and admin dashboard.

## Features

- **JWT Authentication** — Secure login/register with role-based access (Admin, Manager, Receptionist, Guest)
- **Hotel Management** — Create and manage multiple hotel properties
- **Room Booking** — Browse available rooms, make reservations with date selection
- **Billing System** — Automatic bill generation with seasonal rate adjustments
- **Seasonal Rates** — Dynamic pricing based on seasons and demand
- **User Management** — Admin dashboard for managing users and roles
- **Notifications** — Background service for reservation notifications
- **Reports** — Admin reporting dashboard

## Tech Stack

| Layer | Technology |
|-------|-----------|
| Frontend | Angular 19, Angular Material, TypeScript |
| Backend | ASP.NET Core Web API (.NET 9) |
| Database | SQL Server (LocalDB) |
| Auth | JWT (JSON Web Tokens) |
| ORM | Entity Framework Core 9 |
| Testing | xUnit, Moq |

## Project Structure

```
Suiteva/
├── suiteva-client/          # Angular 19 SPA
│   ├── src/app/
│   │   ├── features/        # Admin, Billing, Hotel, Reservation modules
│   │   ├── guards/          # Auth guards
│   │   ├── interceptors/    # JWT interceptor
│   │   ├── layout/          # Dashboard layout
│   │   ├── models/          # TypeScript interfaces
│   │   ├── pages/           # Login, Register, Welcome
│   │   └── services/        # API services
│   └── public/              # Static assets, favicon
├── Suiteva.API/             # ASP.NET Core Web API
│   ├── Controllers/         # API endpoints
│   ├── Data/                # DbContext, seeder
│   ├── DTOs/                # Data transfer objects
│   ├── Helpers/             # JWT helper
│   ├── Middleware/           # Exception handling
│   ├── Models/              # Entity models
│   ├── Repositories/        # Generic repository + Unit of Work
│   └── Services/            # Business logic
├── Suiteva.Tests/           # Unit tests
└── docs/                    # Documentation
```

## Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Node.js 18+](https://nodejs.org/)
- SQL Server LocalDB (included with Visual Studio)

### Backend Setup

```bash
cd Suiteva.API
dotnet restore
dotnet ef database update
dotnet run
```

API runs at `http://localhost:5157` — Swagger UI at `http://localhost:5157/swagger`

### Frontend Setup

```bash
cd suiteva-client
npm install
ng serve
```

Angular app runs at `http://localhost:4200`

### Seeded Users

| Username | Password | Role |
|----------|----------|------|
| admin@suiteva.com | Admin@123 | Admin |
| manager@suiteva.com | Manager@123 | HotelManager |
| receptionist@suiteva.com | Reception@123 | Receptionist |

## API Endpoints

| Method | Endpoint | Auth | Description |
|--------|----------|------|-------------|
| POST | `/api/auth/register` | — | Register new user |
| POST | `/api/auth/login` | — | Login, returns JWT |
| GET | `/api/hotels` | ✅ | List hotels |
| GET | `/api/rooms` | ✅ | List rooms |
| POST | `/api/reservations` | ✅ | Create reservation |
| GET | `/api/reservations` | ✅ | List reservations |
| GET | `/api/bills` | ✅ | List bills |
| GET | `/api/users` | Admin | Manage users |
| GET | `/api/seasonal-rates` | Admin | Manage rates |

## Architecture Patterns

- **Generic Repository + Unit of Work** — Abstracted data access
- **Service Layer** — Business logic decoupled from controllers
- **DTOs** — Clean data transfer between layers
- **JWT Auth + Guards** — Secure API + Angular route protection
- **Interceptors** — Automatic token attachment
- **Exception Middleware** — Centralized error handling
- **Background Services** — Notification processing

## Author

**Ibrahim** — [ibrahimadedayo@rocketmail.com](mailto:ibrahimadedayo@rocketmail.com) — [GitHub](https://github.com/tulbadex)

## License

MIT
