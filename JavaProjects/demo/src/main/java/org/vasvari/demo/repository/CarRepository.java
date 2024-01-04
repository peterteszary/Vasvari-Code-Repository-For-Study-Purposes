package org.vasvari.demo.repository;

import org.springframework.data.repository.CrudRepository;
import org.vasvari.demo.entity.Car;

public interface CarRepository extends CrudRepository<Car,Long> {
}
