package com.mycompany.GaleriaArte.model;


import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.EqualsAndHashCode;
import lombok.NoArgsConstructor;

@EqualsAndHashCode(callSuper = true)
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Escultura extends ObraArte {

    private double altura;
    private double volumen;
    private String material;
    

}
