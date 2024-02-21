using TecNM.Practica3.Core.Enums;

namespace TecNM.Practica3.Core.Entities;

public class ISR{
    public double limiteInferior{get; set;}
    public double cuotaFija{get; set;}
    public double porcentajeExcedente{get; set;}
    public double isrBase {get; set;}
    public double resultado {get; set;}
    public double isrFinal {get; set;}
    public ISRType isrType { get; set;}
}