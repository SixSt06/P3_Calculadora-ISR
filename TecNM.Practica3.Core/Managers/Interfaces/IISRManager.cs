using TecNM.Practica3.Core.Entities;

namespace TecNM.Practica3.Core.Managers.Interfaces;

public interface IISRManager{
    ISR GetSalario(Person person);
}