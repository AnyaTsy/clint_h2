using System.Collections.Generic;
using TodoListAPIi.Models;

namespace TodoListAPI.Interfaces.Repositories
{
    public interface IDeviceRepository
    {
        List<Device> GetDevices();

        int GetDevicesTotalCount();

        Device GetDeviceById(int id);

        Device AddDevice(Device device);
    }
}
