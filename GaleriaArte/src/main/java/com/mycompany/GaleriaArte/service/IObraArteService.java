package com.mycompany.GaleriaArte.service;

import com.mycompany.GaleriaArte.model.Pintura;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.List;


public interface IObraArteService {

    Pintura crearPintura(Pintura p);
    Pintura obtenerPintura(int id);
    Pintura actualizarPintura(int id, Pintura cambios);
    void eliminarPintura(int id); // soft-delete: estado = "Inactivo"

    // Listados
    List<Pintura> listarPinturas();      // solo Activas
    List<Pintura> listarTodasPinturas(); // incluye Inactivas

    // Búsqueda con filtros
    List<Pintura> buscarPinturas(String autor, String estado, Double minPrecio,
                                 String tecnica, String textura,
                                 LocalDateTime fechaIngreso);
}
