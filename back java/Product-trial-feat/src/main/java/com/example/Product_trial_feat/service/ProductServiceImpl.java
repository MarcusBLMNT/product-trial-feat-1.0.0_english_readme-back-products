package com.example.Product_trial_feat.service;

import com.example.Product_trial_feat.model.Product;
import com.example.Product_trial_feat.repo.ProductRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
@Service
@RequiredArgsConstructor
public class ProductServiceImpl implements ProductService{
    private final ProductRepo repo;
    @Override
    public Product createProduct(Product product) {
        return repo.save(product);
    }

    @Override
    public Optional<Product> findProduct(long id) {
        return repo.findById(id);
    }

    @Override
    public List<Product> findAllProduct() {
        return repo.findAll();
    }

    @Override
    public Product updateProduct(long id, Product product) {
       Product toUpdate =  repo.findById(id)
               .stream()
               .findFirst()
               .orElseThrow(() ->
                       new RuntimeException("product with id " + id + " does not exists")
               );
       toUpdate.setCategory(product.getCategory());
       toUpdate.setDescription(product.getDescription());
       toUpdate.setCode(product.getCode());
       toUpdate.setImage(product.getImage());
       toUpdate.setName(product.getName());
       toUpdate.setPrice(product.getPrice());
       toUpdate.setRating(product.getRating());
       toUpdate.setQuantity(product.getQuantity());
       toUpdate.setInventoryStatus(product.getInventoryStatus());
       return repo.save(toUpdate);

    }

    @Override
    public void deleteProduct(long id) {
        Product toDelete =  repo.findById(id).get();
        if (toDelete == null){
            throw new RuntimeException("product with id " + id + " does not exists");
        }
        repo.delete(toDelete);
    }
}
