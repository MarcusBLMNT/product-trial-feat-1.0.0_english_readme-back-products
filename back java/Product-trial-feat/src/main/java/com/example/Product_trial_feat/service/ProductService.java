package com.example.Product_trial_feat.service;

import com.example.Product_trial_feat.model.Product;

import java.util.List;
import java.util.Optional;

public interface ProductService {
    Product createProduct(Product product);
    Optional<Product> findProduct(long id);
    List<Product> findAllProduct();
    Product updateProduct(long id, Product product);
    void deleteProduct(long id);
}
