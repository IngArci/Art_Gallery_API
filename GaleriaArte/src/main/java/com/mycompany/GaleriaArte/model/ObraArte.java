package com.mycompany.GaleriaArte.model;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.LocalDateTime;

@Data
@NoArgsConstructor
@AllArgsConstructor
public class ObraArte {

    private int id;
    private String titulo;
    private String autor;
    private double precio;
    private String estado;
    private LocalDateTime fechaIngreso;
    private String tipo;


}
