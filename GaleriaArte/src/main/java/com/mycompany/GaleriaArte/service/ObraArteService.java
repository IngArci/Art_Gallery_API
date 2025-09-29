package com.mycompany.GaleriaArte.service;

import com.mycompany.GaleriaArte.model.ObraArte;
import com.mycompany.GaleriaArte.model.Pintura;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.NoSuchElementException;

@Service
public class ObraArteService implements IObraArteService {

    private final List<Pintura> data = new ArrayList<>();

    private int indexOfId(int id) {
        for (int i = 0; i < data.size(); i++) {
            if (data.get(i).getId() == id) return i;
        }
        return -1;
    }

    @Override
    public Pintura crearPintura(Pintura p) {
        if (p == null) throw new IllegalArgumentException("Pintura null");
        if (indexOfId(p.getId()) != -1) throw new IllegalArgumentException("ID duplicado: " + p.getId());

        if (p.getFechaIngreso() == null) p.setFechaIngreso(LocalDateTime.now());
        if (p.getEstado() == null || p.getEstado().isBlank()) p.setEstado("Activo");
        p.setTipo("Pintura");

        data.add(p);
        return p;
    }

    @Override
    public Pintura obtenerPintura(int id) {
        int idx = indexOfId(id);
        if (idx == -1) throw new NoSuchElementException("No existe pintura con id " + id);
        return data.get(idx);
    }

    @Override
    public Pintura actualizarPintura(int id, Pintura cambios) {
        if (cambios == null) throw new IllegalArgumentException("Cambios null");
        int idx = indexOfId(id);
        if (idx == -1) throw new NoSuchElementException("No existe pintura con id " + id);

        Pintura actual = data.get(idx);
        // Campos de ObraArte (heredados)
        actual.setTitulo(cambios.getTitulo());
        actual.setAutor(cambios.getAutor());
        actual.setPrecio(cambios.getPrecio());
        actual.setEstado(cambios.getEstado());
        if (cambios.getFechaIngreso() != null) {
            actual.setFechaIngreso(cambios.getFechaIngreso());
        }
        actual.setTipo("Pintura");


        actual.setTecnica(cambios.getTecnica());
        actual.setTextura(cambios.getTextura());

        return actual;
    }

    @Override
    public void eliminarPintura(int id) {
        int idx = indexOfId(id);
        if (idx == -1) throw new NoSuchElementException("No existe pintura con id " + id);
        data.get(idx).setEstado("Inactivo"); // soft-delete
    }

    @Override
    public List<Pintura> listarPinturas() {
        List<Pintura> out = new ArrayList<>();
        for (Pintura p : data) {
            if (!"Inactivo".equalsIgnoreCase(p.getEstado())) out.add(p);
        }
        return out;
    }

    @Override
    public List<Pintura> listarTodasPinturas() {
        return new ArrayList<>(data);
    }

    @Override
    public List<Pintura> buscarPinturas(String autor, String estado, Double minPrecio,
                                        String tecnica, String textura,
                                        LocalDateTime fechaIngreso) {
        List<Pintura> out = new ArrayList<>();
        for (Pintura p : data) {
            if (autor != null && (p.getAutor() == null || !p.getAutor().equalsIgnoreCase(autor))) continue;
            if (estado != null && (p.getEstado() == null || !p.getEstado().equalsIgnoreCase(estado))) continue;
            if (minPrecio != null && p.getPrecio() < minPrecio) continue;
            if (tecnica != null && (p.getTecnica() == null || !p.getTecnica().equalsIgnoreCase(tecnica))) continue;
            if (textura != null && (p.getTextura() == null || !p.getTextura().equalsIgnoreCase(textura))) continue;
            if (fechaIngreso != null && (p.getFechaIngreso() == null || !p.getFechaIngreso().equals(fechaIngreso))) continue;
            out.add(p);
        }
        return out;
    }

}
