package com.mycompany.GaleriaArte.service;

import com.mycompany.GaleriaArte.model.ObraArte;
import com.mycompany.GaleriaArte.model.Pintura;
import com.mycompany.GaleriaArte.model.Escultura;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.NoSuchElementException;

@Service
public class ObraArteService implements IObraArteService {

    private final List<ObraArte> data = new ArrayList<>();

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
        if (idx == -1 || !(data.get(idx) instanceof Pintura)) {
            throw new NoSuchElementException("No existe pintura con id " + id);
        }
        return (Pintura) data.get(idx);
    }

    @Override
    public Pintura actualizarPintura(int id, Pintura cambios) {
        if (cambios == null) throw new IllegalArgumentException("Cambios null");
        Pintura actual = obtenerPintura(id); // valida existencia y tipo
        actual.setTitulo(cambios.getTitulo());
        actual.setAutor(cambios.getAutor());
        actual.setPrecio(cambios.getPrecio());
        actual.setEstado(cambios.getEstado());
        if (cambios.getFechaIngreso() != null) actual.setFechaIngreso(cambios.getFechaIngreso());
        actual.setTipo("Pintura");
        actual.setTecnica(cambios.getTecnica());
        actual.setTextura(cambios.getTextura());
        return actual;
    }

    @Override
    public void eliminarPintura(int id) {
        Pintura p = obtenerPintura(id);
        p.setEstado("Inactivo"); // soft-delete
    }

    @Override
    public List<Pintura> listarPinturas() {
        List<Pintura> out = new ArrayList<>();
        for (ObraArte o : data) {
            if (o instanceof Pintura p && !"Inactivo".equalsIgnoreCase(p.getEstado())) {
                out.add(p);
            }
        }
        return out;
    }

    @Override
    public List<Pintura> listarTodasPinturas() {
        List<Pintura> out = new ArrayList<>();
        for (ObraArte o : data) if (o instanceof Pintura p) out.add(p);
        return out;
    }

    @Override
    public List<Pintura> buscarPinturas(String autor, String estado, Double minPrecio,
                                        String tecnica, String textura,
                                        LocalDateTime fechaIngreso) {
        List<Pintura> out = new ArrayList<>();
        for (ObraArte o : data) {
            if (!(o instanceof Pintura p)) continue;

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

    @Override
    public Escultura crearEscultura(Escultura e) {
        if (e == null) throw new IllegalArgumentException("Escultura null");
        if (indexOfId(e.getId()) != -1) throw new IllegalArgumentException("ID duplicado: " + e.getId());
        if (e.getFechaIngreso() == null) e.setFechaIngreso(LocalDateTime.now());
        if (e.getEstado() == null || e.getEstado().isBlank()) e.setEstado("Activo");
        e.setTipo("Escultura");
        data.add(e);
        return e;
    }

    @Override
    public Escultura obtenerEscultura(int id) {
        int idx = indexOfId(id);
        if (idx == -1 || !(data.get(idx) instanceof Escultura)) {
            throw new NoSuchElementException("No existe escultura con id " + id);
        }
        return (Escultura) data.get(idx);
    }

    @Override
    public Escultura actualizarEscultura(int id, Escultura cambios) {
        if (cambios == null) throw new IllegalArgumentException("Cambios null");
        Escultura actual = obtenerEscultura(id);
        actual.setTitulo(cambios.getTitulo());
        actual.setAutor(cambios.getAutor());
        actual.setPrecio(cambios.getPrecio());
        actual.setEstado(cambios.getEstado());
        if (cambios.getFechaIngreso() != null) actual.setFechaIngreso(cambios.getFechaIngreso());
        actual.setTipo("Escultura");
        actual.setAltura(cambios.getAltura());
        actual.setVolumen(cambios.getVolumen());
        actual.setMaterial(cambios.getMaterial());
        actual.setTipoEscultura(cambios.getTipoEscultura());
        return actual;
    }

    @Override
    public void eliminarEscultura(int id) {
        Escultura e = obtenerEscultura(id);
        e.setEstado("Inactivo"); // soft-delete
    }

    @Override
    public List<Escultura> listarEsculturas() {
        List<Escultura> out = new ArrayList<>();
        for (ObraArte o : data) {
            if (o instanceof Escultura e && !"Inactivo".equalsIgnoreCase(e.getEstado())) {
                out.add(e);
            }
        }
        return out;
    }

    @Override
    public List<Escultura> listarTodasEsculturas() {
        List<Escultura> out = new ArrayList<>();
        for (ObraArte o : data) if (o instanceof Escultura e) out.add(e);
        return out;
    }

    @Override
    public List<Escultura> buscarEsculturas(String material, String tipoEscultura,
                                            String estado, Double minPrecio,
                                            LocalDateTime fechaIngreso) {
        List<Escultura> out = new ArrayList<>();
        for (ObraArte o : data) {
            if (!(o instanceof Escultura e)) continue;

            if (material != null && (e.getMaterial() == null || !e.getMaterial().equalsIgnoreCase(material))) continue;
            if (tipoEscultura != null && (e.getTipoEscultura() == null || !e.getTipoEscultura().equalsIgnoreCase(tipoEscultura))) continue;
            if (estado != null && (e.getEstado() == null || !e.getEstado().equalsIgnoreCase(estado))) continue;
            if (minPrecio != null && e.getPrecio() < minPrecio) continue;
            if (fechaIngreso != null && (e.getFechaIngreso() == null || !e.getFechaIngreso().equals(fechaIngreso))) continue;

            out.add(e);
        }
        return out;
    }
}
