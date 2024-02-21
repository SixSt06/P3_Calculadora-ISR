using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers.Interfaces;
using TecNM.Practica3.Core.Services.interfaces;

namespace TecNM.Practica3.Core.Managers;

public class ISRManager : IISRManager{
    private readonly IISRService _service;

    public ISRManager(IISRService service){
        _service = service;
    }

    public ISR GetSalario(Person person){
        return _service.ProcessISR(person);
    }
}   