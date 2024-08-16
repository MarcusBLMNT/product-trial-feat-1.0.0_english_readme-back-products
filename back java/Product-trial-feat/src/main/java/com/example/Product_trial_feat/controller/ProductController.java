package com.example.Product_trial_feat.controller;

import com.example.Product_trial_feat.model.Product;
import com.example.Product_trial_feat.service.ProductService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("product")
@RequiredArgsConstructor
@CrossOrigin(origins = "*", allowedHeaders = "*")
public class ProductController {
    private final ProductService service;
    @PostMapping
    public ResponseEntity<Product> postProduct(@RequestBody Product product){
        product.setId(0);
       return new ResponseEntity<>(service.createProduct(product), HttpStatus.CREATED);
    }
    @GetMapping
    public ResponseEntity<List<Product>> getProducts(){
        return new ResponseEntity<>(service.findAllProduct(), HttpStatus.OK);
    }
    @GetMapping("{id}")
    public ResponseEntity<Product> getProduct(@PathVariable("id")long id){
        Optional<Product> p = service.findProduct(id);
        return p.map(product ->
                new ResponseEntity<>(product, HttpStatus.OK)).orElseGet(() ->
                new ResponseEntity<>(null, HttpStatus.NO_CONTENT));

    }
    @PatchMapping("{id}")
    public ResponseEntity<Product> patchProduct(@PathVariable("id")long id, @RequestBody Product product){
        return new ResponseEntity<>(service.updateProduct(id, product), HttpStatus.OK);
    }
    @DeleteMapping("{id}")
    public ResponseEntity<Integer> deleteProduct(@PathVariable("id")long id){
        service.deleteProduct(id);
        return new ResponseEntity<>(0, HttpStatus.NO_CONTENT);
    }
}
