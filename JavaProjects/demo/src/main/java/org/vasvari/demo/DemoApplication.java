package org.vasvari.demo;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.vasvari.demo.entity.Car;
import org.vasvari.demo.repository.CarRepository;

@SpringBootApplication
public class DemoApplication implements CommandLineRunner {

	private static final Logger logger = LoggerFactory.getLogger(
			DemoApplication.class
	);

	private final CarRepository repository;

	public DemoApplication(CarRepository repository) {
		this.repository = repository;
	}

	public static void main(String[] args) {
		// After adding this comment the application is restarted
		SpringApplication.run(DemoApplication.class, args);
		logger.info("Application started");
	}

	@Override
	public void run(String... args) throws Exception {
		repository.save(new Car("Ford", "Mustang", "Red","ADF-1121", 2023, 59000));
		repository.save(new Car("Nissan", "Leaf", "White","SSJ-3002", 2020, 29000));
		repository.save(new Car("Toyota", "Prius","Silver", "KKO-0212", 2022, 39000));
		// Fetch all cars and log to console
		for (Car car : repository.findAll()) {
			logger.info("brand: {}, model: {}",
					car.getBrand(), car.getModel());
		}
	}
}
