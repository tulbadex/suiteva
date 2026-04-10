using Suiteva.API.Data;
using Suiteva.API.Models;

namespace Suiteva.API.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly SuitevaDbContext _context;
    private IGenericRepository<Hotel>? _hotels;
    private IGenericRepository<Room>? _rooms;
    private IGenericRepository<Reservation>? _reservations;
    private IGenericRepository<Bill>? _bills;

    public UnitOfWork(SuitevaDbContext context)
    {
        _context = context;
    }

    public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);
    public IGenericRepository<Room> Rooms => _rooms ??= new GenericRepository<Room>(_context);
    public IGenericRepository<Reservation> Reservations => _reservations ??= new GenericRepository<Reservation>(_context);
    public IGenericRepository<Bill> Bills => _bills ??= new GenericRepository<Bill>(_context);

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}