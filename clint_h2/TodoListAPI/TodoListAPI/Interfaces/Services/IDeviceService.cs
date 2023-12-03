using System.Collections.Generic;
using TodoListAPI.Models;

namespace TodoListAPI.Interfaces.Services
{
    public interface IDeviceService
    {
        Device GetDeviceById(int id);

        List<Device> GetDevices(out int totalCount);

        Device AddDevice(Device device);
    }
}
