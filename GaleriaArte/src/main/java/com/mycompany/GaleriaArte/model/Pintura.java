package com.mycompany.GaleriaArte.model;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Pintura extends ObraArte {

    private String tecnica;

    private String textura;

}
