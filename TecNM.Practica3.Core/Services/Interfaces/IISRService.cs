using TecNM.Practica3.Core.Entities;

namespace TecNM.Practica3.Core.Services.interfaces;

public interface IISRService{
    ISR ProcessISR(Person person);
}