using AutoMapper;
using InventorySystemAPI.DataTransferObjects.StatusDtos;
using InventorySystemAPI.Entities;
using InventorySystemAPI.Repositories.IRepositories;
using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class StatusService : IStatusService
{
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;
    
    public StatusService(IRepositoryManager repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<StatusDto> GetStatusAsync(int id)
    {
        var status = await _repository.StatusRepository.GetStatusAsync(id, false);

        var statusToReturn = _mapper.Map<StatusDto>(status);

        return statusToReturn;
    }
    
    public async Task<IEnumerable<StatusDto>> GetStatusesAsync()
    {
        var statuses = await _repository.StatusRepository.GetStatusesAsync();
        var statusesToReturn = _mapper.Map<IEnumerable<StatusDto>>(statuses);

        return statusesToReturn;
    }
    
    public async Task<StatusDto> CreateStatusAsync(StatusForCreationDto status)
    {
        var statusEntity = _mapper.Map<Status>(status);
        
        _repository.StatusRepository.CreateStatus(statusEntity);
        await _repository.SaveAsync();
        
        var statusToReturn = _mapper.Map<StatusDto>(statusEntity);
        
        return statusToReturn;
    }
    
    public async Task<StatusDto> UpdateStatusAsync(StatusDto status)
    {
        throw new NotImplementedException();
    }
    
    public async Task DeleteStatusAsync(int id)
    {
        throw new NotImplementedException();
    }
    
    
}