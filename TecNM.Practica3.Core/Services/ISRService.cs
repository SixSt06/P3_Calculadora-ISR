using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Enums;
using TecNM.Practica3.Core.Services.interfaces;

namespace TecNM.Practica3.Core.Services;

public class ISRService : IISRService{
    public ISR ProcessISR(Person person){
        var isr = new ISR();

        if(person.salario > 0.01 && person.salario < 7735.00){
            isr.cuotaFija = 0.00;
            isr.limiteInferior = 0.01;
            isr.porcentajeExcedente = 1.92;
            isr.isrType = ISRType.type1;

        }else if(person.salario > 7735.01 && person.salario < 65651.07){
            isr.cuotaFija = 148.51;
            isr.limiteInferior = 7735.01;
            isr.porcentajeExcedente = 6.40;
            isr.isrType = ISRType.type2;
            
        }else if(person.salario > 65651.08 && person.salario < 115375.90){
            isr.cuotaFija = 3855.14;
            isr.limiteInferior = 65651.08;
            isr.porcentajeExcedente = 10.88;
            isr.isrType = ISRType.type3;
            
        }else if(person.salario >= 115375.91 && person.salario <= 134119.41){
            isr.cuotaFija = 9265.20;
            isr.limiteInferior = 115375.91;
            isr.porcentajeExcedente = 16;
            isr.isrType = ISRType.type4;
            
        }else if(person.salario >= 134119.42 && person.salario <= 160577.65){
            isr.cuotaFija = 12262.16;
            isr.limiteInferior = 134119.42;
            isr.porcentajeExcedente = 17.92;
            isr.isrType = ISRType.type5;
            
        }else if(person.salario >= 160577.66 && person.salario <= 323862){
            isr.cuotaFija = 17005.47;
            isr.limiteInferior = 160577.66;
            isr.porcentajeExcedente = 21.36;
            isr.isrType = ISRType.type6;
            
        }else if(person.salario >= 323862.01 && person.salario <= 510451){
            isr.cuotaFija = 51883.01;
            isr.limiteInferior = 323862.01;
            isr.porcentajeExcedente = 23.52;
            isr.isrType = ISRType.type7;
            
        }else if(person.salario >= 510451.01 && person.salario <= 974535.04){
            isr.cuotaFija = 92768.74;
            isr.limiteInferior = 510451.01;
            isr.porcentajeExcedente = 30;
            isr.isrType = ISRType.type8;

        }else if(person.salario >= 974535.04 && person.salario <= 1299380.04){
            isr.limiteInferior = 974535.04;
            isr.cuotaFija = 234993.95;
            isr.porcentajeExcedente = 32;
            isr.isrType = ISRType.type9;
            
        }else if(person.salario >= 1299380.05 && person.salario <= 3898140.12){
            isr.limiteInferior = 1299380.05;
            isr.cuotaFija = 338944.34;
            isr.porcentajeExcedente = 34f;
            isr.isrType = ISRType.type10;
            
        }else if(person.salario >= 3898140.13){
            isr.limiteInferior = 3898140.13;
            isr.cuotaFija = 1222522.76;
            isr.porcentajeExcedente = 35;
            isr.isrType = ISRType.type11;
        }
        
        isr.isrBase = person.salario - isr.limiteInferior;
        isr.resultado = isr.isrBase * (isr.porcentajeExcedente / 100);
        isr.isrFinal = isr.resultado + isr.cuotaFija;
        return isr;
    }
}