package entities.model;

import javax.persistence.*;
import java.util.Set;

@Entity
@Table(name = "shampoos")
@Inheritance(strategy = InheritanceType.SINGLE_TABLE)
public abstract class BasicShampoo {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @OneToOne(optional = false,cascade = CascadeType.PERSIST)
    @JoinColumn(name = "label_id")
    private ClassicLabel label;

    @ManyToOne(optional = false,cascade = CascadeType.PERSIST)
    @JoinColumn(name = "batch_id")
    private ProductionBatch batch;

    @ManyToMany(fetch = FetchType.EAGER)
    @JoinTable(name = "shampoos_ingredients",
    joinColumns = @JoinColumn(name = "shampoo_id"),
    inverseJoinColumns = @JoinColumn(name = "ingredient_id"))
    private Set<BasicIngredient> ingredients;

    public BasicShampoo() {
    }

    public BasicShampoo(ClassicLabel label) {
        this.label = label;
    }


    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public ProductionBatch getBatch() {
        return batch;
    }

    public void setBatch(ProductionBatch batch) {
        this.batch = batch;
    }

    public ClassicLabel getLabel() {
        return label;
    }

    public void setLabel(ClassicLabel label) {
        this.label = label;
    }

    public Set<BasicIngredient> getIngredients() {
        return ingredients;
    }

    public void setIngredients(Set<BasicIngredient> ingredients) {
        this.ingredients = ingredients;
    }

    @Override
    public String toString() {
        return "BasicShampoo{" +
                "id=" + id +
                ", label=" + label +
                ", ingredients=" + ingredients +
                '}';
    }
}
