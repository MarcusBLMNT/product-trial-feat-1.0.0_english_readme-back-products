package com.example.Product_trial_feat.model;
import jakarta.persistence.*;
import jdk.jfr.Name;
import lombok.Data;
import lombok.Generated;


@Data
@Entity
@Table(name="product")
public class Product {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)

    private long id;
    private String code;
    private String name;
    private String description;
    private String image;
    private Integer price;
    private String category;
    private Integer quantity;
    private String inventoryStatus;
    private Integer rating;
}
