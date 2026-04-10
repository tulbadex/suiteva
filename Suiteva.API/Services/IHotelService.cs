using Suiteva.API.DTOs;

namespace Suiteva.API.Services;

public interface IHotelService
{
    Task<IEnumerable<HotelDto>> GetAllHotelsAsync();
    Task<HotelDto?> GetHotelByIdAsync(int id);
    Task<HotelDto> CreateHotelAsync(CreateHotelDto createHotelDto);
    Task<HotelDto?> UpdateHotelAsync(int id, UpdateHotelDto updateHotelDto);
    Task<bool> DeleteHotelAsync(int id);
}