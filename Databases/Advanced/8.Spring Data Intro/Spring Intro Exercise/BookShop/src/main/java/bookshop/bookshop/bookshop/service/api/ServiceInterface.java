package bookshop.bookshop.bookshop.service.api;

import java.util.List;

public interface ServiceInterface<E, K> {

    E findById(K id);

    void remove(E object);

    List<E> findAll();

    void save (E object);
}