package com.example.Product_trial_feat.repo;

import com.example.Product_trial_feat.model.Product;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.rest.core.annotation.RepositoryRestResource;

@RepositoryRestResource
public interface ProductRepo extends JpaRepository<Product, Long> {
}
