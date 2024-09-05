using System.Collections.Generic;
using System.Threading.Tasks;
using System;

public interface ICafeRepository
{
    Task<IEnumerable<Cafe>> GetCafesAsync(string location = null);
    Task<Cafe> GetCafeByIdAsync(Guid id);
    Task CreateCafeAsync(Cafe cafe);
    Task UpdateCafeAsync(Cafe cafe);
    Task DeleteCafeAsync(Guid id);
}

